
using RobotControlLibrary;
using RobotControlLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotControlUI
{
    public partial class SchedulerForm : Form
    {
        private List<RoutineStepModel> currentRoutineSteps;
        private List<DeviceModel> devices;
        private int stepCounter = 1;

        public SchedulerForm()
        {
            InitializeComponent();
            currentRoutineSteps = new List<RoutineStepModel>();
        }

        private void SchedulerForm_Load(object sender, EventArgs e)
        {
            // Populate command dropdown
            PopulateCommandDropdown();

            // Load devices
            LoadDevices();

            // Load saved routines
            LoadSavedRoutines();

            // Set initial status
            lblExecutionStatus.Text = "Ready";
            lblExecutionStatus.ForeColor = Color.FromArgb(40, 167, 69); // Green
        }

        private void PopulateCommandDropdown()
        {
            cbStepCommand.Items.Clear();
            cbStepCommand.Items.Add("Pick");
            cbStepCommand.Items.Add("Place");
            cbStepCommand.Items.Add("MoveForward");
            cbStepCommand.Items.Add("Reverse");
            cbStepCommand.Items.Add("TurnLeft");
            cbStepCommand.Items.Add("TurnRight");
            cbStepCommand.Items.Add("AboutTurn");
            cbStepCommand.Items.Add("Home");
            cbStepCommand.Items.Add("Stop");

            if (cbStepCommand.Items.Count > 0)
                cbStepCommand.SelectedIndex = 0;
        }

        private void LoadDevices()
        {
            try
            {
                devices = GlobalConfig.Connection.GetAllDevices();

                cbTargetDevice.Items.Clear();

                if (devices != null && devices.Count > 0)
                {
                    foreach (var device in devices)
                    {
                        cbTargetDevice.Items.Add(device.DisplayName);
                    }

                    cbTargetDevice.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No devices found. Please add a device first.", "No Devices",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading devices: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSavedRoutines()
        {
            try
            {
                List<RoutineModel> routines = GlobalConfig.Connection.GetAllRoutines();

                cbSavedRoutines.Items.Clear();

                if (routines != null && routines.Count > 0)
                {
                    foreach (var routine in routines)
                    {
                        cbSavedRoutines.Items.Add(routine.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading routines: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbStepCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCommand = cbStepCommand.SelectedItem?.ToString();

            // Enable/disable distance based on command
            if (selectedCommand == "MoveForward" || selectedCommand == "Reverse")
            {
                nudStepDistance.Enabled = true;
                lblStepDistance.Enabled = true;
            }
            else
            {
                nudStepDistance.Enabled = false;
                lblStepDistance.Enabled = false;
            }
        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            if (cbStepCommand.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a command.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string commandType = cbStepCommand.SelectedItem.ToString();

            // Build payload JSON
            string payloadJson = BuildPayloadJson(commandType);

            // Create routine step model
            RoutineStepModel step = new RoutineStepModel
            {
                StepOrder = stepCounter++,
                CommandType = commandType,
                PayloadJson = payloadJson,
                DwellMs = (int)nudStepDwell.Value
            };

            currentRoutineSteps.Add(step);

            // Add to listbox display
            string display = $"Step {step.StepOrder}: {commandType} - Speed:{nudStepSpeed.Value}";

            if (commandType == "MoveForward" || commandType == "Reverse")
            {
                display += $", Distance:{nudStepDistance.Value}cm";
            }

            display += $" (Wait: {step.DwellMs}ms)";

            lbRoutineSteps.Items.Add(display);

            // Reset dwell to default
            nudStepDwell.Value = 1000;
        }

        private string BuildPayloadJson(string commandType)
        {
            var payload = new System.Text.StringBuilder();
            payload.Append("{");

            // Always include speed
            payload.Append($"\"speed\": {nudStepSpeed.Value}");

            // Add distance if applicable
            if (commandType == "MoveForward" || commandType == "Reverse")
            {
                payload.Append($", \"distance\": {nudStepDistance.Value}");
            }

            payload.Append("}");
            return payload.ToString();
        }

        private void btnRemoveStep_Click(object sender, EventArgs e)
        {
            if (lbRoutineSteps.SelectedIndex >= 0)
            {
                int selectedIndex = lbRoutineSteps.SelectedIndex;

                // Remove from list
                currentRoutineSteps.RemoveAt(selectedIndex);
                lbRoutineSteps.Items.RemoveAt(selectedIndex);

                // Renumber steps
                RenumberSteps();
            }
            else
            {
                MessageBox.Show("Please select a step to remove.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RenumberSteps()
        {
            // Update step orders
            for (int i = 0; i < currentRoutineSteps.Count; i++)
            {
                currentRoutineSteps[i].StepOrder = i + 1;
            }

            // Rebuild listbox display
            lbRoutineSteps.Items.Clear();
            foreach (var step in currentRoutineSteps)
            {
                string display = $"Step {step.StepOrder}: {step.CommandType}";

                // Parse payload to show details
                if (step.PayloadJson.Contains("distance"))
                {
                    display += " with distance";
                }

                display += $" (Wait: {step.DwellMs}ms)";
                lbRoutineSteps.Items.Add(display);
            }

            stepCounter = currentRoutineSteps.Count + 1;
        }

        private void btnSaveRoutine_Click(object sender, EventArgs e)
        {
            // Validate routine name
            if (string.IsNullOrWhiteSpace(txtRoutineName.Text))
            {
                MessageBox.Show("Please enter a routine name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoutineName.Focus();
                return;
            }

            if (currentRoutineSteps.Count == 0)
            {
                MessageBox.Show("Please add at least one step to the routine.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RoutineModel routine = GlobalConfig.Connection.CreateRoutine(
                    txtRoutineName.Text.Trim(),
                    txtRoutineDescription.Text.Trim(),
                    SessionManager.CurrentUserId,
                    currentRoutineSteps
                );

                if (routine != null)
                {
                    MessageBox.Show($"Routine '{routine.Name}' saved successfully with {routine.Steps.Count} steps!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Log the action
                    GlobalConfig.Connection.CreateLog(
                        null,
                        "Info",
                        $"Routine '{routine.Name}' created by {SessionManager.CurrentUsername}"
                    );

                    // Clear the form
                    ClearRoutineBuilder();

                    // Reload saved routines
                    LoadSavedRoutines();
                }
                else
                {
                    MessageBox.Show("Failed to save routine.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving routine: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearRoutineBuilder()
        {
            txtRoutineName.Clear();
            txtRoutineDescription.Clear();
            lbRoutineSteps.Items.Clear();
            currentRoutineSteps.Clear();
            stepCounter = 1;
        }

        private void cbSavedRoutines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSavedRoutines.SelectedIndex < 0)
                return;

            try
            {
                List<RoutineModel> routines = GlobalConfig.Connection.GetAllRoutines();
                string selectedRoutineName = cbSavedRoutines.SelectedItem.ToString();

                RoutineModel selectedRoutine = routines.FirstOrDefault(r => r.Name == selectedRoutineName);

                if (selectedRoutine != null)
                {
                    // Load full routine with steps
                    RoutineModel fullRoutine = GlobalConfig.Connection.GetRoutineById(selectedRoutine.RoutineId);

                    if (fullRoutine != null)
                    {
                        // Display routine info
                        lblRoutineInfo.Text = $"Name: {fullRoutine.Name}\n" +
                                            $"Description: {fullRoutine.Description ?? "N/A"}\n" +
                                            $"Steps: {fullRoutine.Steps.Count}\n" +
                                            $"Created: {fullRoutine.CreatedAt.ToLocalTime():MM/dd/yyyy}";

                        // Display steps in preview
                        lbRoutinePreview.Items.Clear();
                        foreach (var step in fullRoutine.Steps)
                        {
                            string display = $"Step {step.StepOrder}: {step.CommandType}";

                            if (step.PayloadJson != null && step.PayloadJson.Contains("distance"))
                            {
                                display += " (with distance)";
                            }

                            display += $" - Wait: {step.DwellMs ?? 0}ms";
                            lbRoutinePreview.Items.Add(display);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading routine details: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExecuteRoutine_Click(object sender, EventArgs e)
        {
            if (cbSavedRoutines.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a routine to execute.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbTargetDevice.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a target device.", "No Device",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get selected routine
                List<RoutineModel> routines = GlobalConfig.Connection.GetAllRoutines();
                string selectedRoutineName = cbSavedRoutines.SelectedItem.ToString();
                RoutineModel selectedRoutine = routines.FirstOrDefault(r => r.Name == selectedRoutineName);

                if (selectedRoutine == null)
                {
                    MessageBox.Show("Routine not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Load full routine with steps
                RoutineModel fullRoutine = GlobalConfig.Connection.GetRoutineById(selectedRoutine.RoutineId);

                if (fullRoutine == null || fullRoutine.Steps.Count == 0)
                {
                    MessageBox.Show("Routine has no steps.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get selected device
                DeviceModel selectedDevice = devices[cbTargetDevice.SelectedIndex];

                // Generate a group ID for this routine execution
                Guid groupId = Guid.NewGuid();

                // Create commands for each step
                int commandsCreated = 0;
                foreach (var step in fullRoutine.Steps)
                {
                    CommandModel command = GlobalConfig.Connection.CreateCommand(
                        selectedDevice.DeviceId,
                        step.CommandType,
                        step.PayloadJson,
                        SessionManager.CurrentUserId
                    );

                    if (command != null)
                    {
                        commandsCreated++;
                    }
                }

                if (commandsCreated > 0)
                {
                    lblExecutionStatus.Text = $"✅ Routine '{fullRoutine.Name}' queued! {commandsCreated} commands sent. Group ID: {groupId}";
                    lblExecutionStatus.ForeColor = Color.FromArgb(40, 167, 69); // Green

                    MessageBox.Show(
                        $"Routine '{fullRoutine.Name}' has been queued for execution!\n\n" +
                        $"Commands sent: {commandsCreated}\n" +
                        $"Group ID: {groupId}\n\n" +
                        $"The robot will execute these commands in sequence.",
                        "Routine Queued",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Log the execution
                    GlobalConfig.Connection.CreateLog(
                        selectedDevice.DeviceId,
                        "Info",
                        $"Routine '{fullRoutine.Name}' queued by {SessionManager.CurrentUsername} - {commandsCreated} commands"
                    );
                }
                else
                {
                    lblExecutionStatus.Text = "❌ Failed to queue routine commands.";
                    lblExecutionStatus.ForeColor = Color.FromArgb(220, 53, 69); // Red

                    MessageBox.Show("Failed to create commands for routine.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                lblExecutionStatus.Text = $"❌ Error: {ex.Message}";
                lblExecutionStatus.ForeColor = Color.FromArgb(220, 53, 69); // Red

                MessageBox.Show($"Error executing routine: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
