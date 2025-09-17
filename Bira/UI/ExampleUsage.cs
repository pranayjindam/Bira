//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static Bira.UI.FormLayout;
//using static Bira.UI.InputControls;
//using static Bira.UI.UIControls;

//namespace Bira.UI
//{
//    internal class ExampleUsage
//    {
 
//        /// <summary>
//        /// Example demonstrating how to use the BiraUIControls library
//        /// </summary>
//        public partial class ExampleForm : Form
//        {
//            public ExampleForm()
//            {
//                InitializeComponent();
//            }

//            private void InitializeComponent()
//            {
//                // Apply consistent form styling
//                FormLayoutHelper.ApplyFormStyling(this, "Example Form");
//                this.Size = new Size(500, 600);

//                // Create header
//                var headerLabel = UIControlFactory.CreateLabelHeader("User Registration",
//                    new Point(FormLayoutHelper.StandardMargin, FormLayoutHelper.StandardMargin),
//                    fontSize: 16F);
//                this.Controls.Add(headerLabel);

//                // Create subtitle
//                var subtitleLabel = UIControlFactory.CreateSubtitleLabel("Please fill in your information",
//                    new Point(FormLayoutHelper.StandardMargin,
//                    FormLayoutHelper.GetNextControlPosition(headerLabel, 5).Y));
//                this.Controls.Add(subtitleLabel);

//                int currentY = FormLayoutHelper.GetNextControlPosition(subtitleLabel,
//                    FormLayoutHelper.SectionSpacing).Y;

//                // Create input groups using the helper
//                var firstNameInput = FormLayoutHelper.CreateInputGroup(this, "First Name:",
//                    new Point(FormLayoutHelper.StandardMargin, currentY), InputType.TextBox);

//                currentY = FormLayoutHelper.GetNextControlPosition(firstNameInput,
//                    FormLayoutHelper.SectionSpacing).Y;

//                var lastNameInput = FormLayoutHelper.CreateInputGroup(this, "Last Name:",
//                    new Point(FormLayoutHelper.StandardMargin, currentY), InputType.TextBox);

//                currentY = FormLayoutHelper.GetNextControlPosition(lastNameInput,
//                    FormLayoutHelper.SectionSpacing).Y;

//                var emailInput = FormLayoutHelper.CreateInputGroup(this, "Email:",
//                    new Point(FormLayoutHelper.StandardMargin, currentY), InputType.TextBox);

//                currentY = FormLayoutHelper.GetNextControlPosition(emailInput,
//                    FormLayoutHelper.SectionSpacing).Y;

//                var passwordInput = FormLayoutHelper.CreateInputGroup(this, "Password:",
//                    new Point(FormLayoutHelper.StandardMargin, currentY), InputType.Password);

//                currentY = FormLayoutHelper.GetNextControlPosition(passwordInput,
//                    FormLayoutHelper.SectionSpacing).Y;

//                var roleCombo = FormLayoutHelper.CreateInputGroup(this, "Role:",
//                    new Point(FormLayoutHelper.StandardMargin, currentY), InputType.ComboBox);

//                // Populate combo box
//                if (roleCombo is ComboBox combo)
//                {
//                    combo.Items.AddRange(new[] { "Member", "Team Lead", "Admin" });
//                }

//                currentY = FormLayoutHelper.GetNextControlPosition(roleCombo,
//                    FormLayoutHelper.SectionSpacing).Y;

//                var birthDatePicker = FormLayoutHelper.CreateInputGroup(this, "Birth Date:",
//                    new Point(FormLayoutHelper.StandardMargin, currentY), InputType.DatePicker);

//                currentY = FormLayoutHelper.GetNextControlPosition(birthDatePicker,
//                    FormLayoutHelper.SectionSpacing).Y;

//                var bioInput = FormLayoutHelper.CreateInputGroup(this, "Bio:",
//                    new Point(FormLayoutHelper.StandardMargin, currentY), InputType.MultiLine,
//                    new Size(400, 80));

//                // Create button group
//                currentY = FormLayoutHelper.GetNextControlPosition(bioInput,
//                    FormLayoutHelper.SectionSpacing).Y;

//                var buttons = new ButtonConfig[]
//                {
//                new ButtonConfig("Register", ButtonType.Primary, clickHandler: RegisterButton_Click),
//                new ButtonConfig("Cancel", ButtonType.Secondary, clickHandler: CancelButton_Click),
//                new ButtonConfig("Reset", ButtonType.Default, clickHandler: ResetButton_Click)
//                };

//                FormLayoutHelper.CreateButtonGroup(this, buttons,
//                    new Point(FormLayoutHelper.StandardMargin, currentY),
//                    ButtonAlignment.Horizontal);
//            }

//            private void RegisterButton_Click(object sender, EventArgs e)
//            {
//                MessageBox.Show("Registration submitted!", "Success",
//                    MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }

//            private void CancelButton_Click(object sender, EventArgs e)
//            {
//                this.Close();
//            }

//            private void ResetButton_Click(object sender, EventArgs e)
//            {
//                // Reset all form controls
//                foreach (Control control in this.Controls)
//                {
//                    if (control is TextBox textBox)
//                    {
//                        textBox.Clear();
//                    }
//                    else if (control is ComboBox comboBox)
//                    {
//                        comboBox.SelectedIndex = -1;
//                    }
//                    else if (control is DateTimePicker datePicker)
//                    {
//                        datePicker.Value = DateTime.Now;
//                    }
//                }
//            }
//        }

//        /// <summary>
//        /// Example of creating individual controls
//        /// </summary>
//        public class IndividualControlsExample
//        {
//            public static void CreateControlsExample(Form parentForm)
//            {
//                // Create various button types
//                var primaryBtn = UIControlFactory.CreatePrimaryButton("Save" );
//                var secondaryBtn = UIControlFactory.CreateSecondaryButton("Cancel" );
//                var defaultBtn = UIControlFactory.CreateInputButton("Reset");

//                parentForm.Controls.AddRange(new Control[] { primaryBtn, secondaryBtn, defaultBtn });

//                // Create various label types
//                var headerLabel = UIControlFactory.CreateLabelHeader("Main Title", new Point(20, 70));
//                var subtitleLabel = UIControlFactory.CreateSubtitleLabel("Subtitle text", new Point(20, 100));
//                var textLabel = UIControlFactory.CreateTextLabel("Regular text", new Point(20, 130));

//                parentForm.Controls.AddRange(new Control[] { headerLabel, subtitleLabel, textLabel });

//                // Create various input controls
//                var textInput = InputControlFactory.CreateTextInput(new Point(20, 160),
//                    placeholder: "Enter your name");
//                var passwordInput = InputControlFactory.CreateTextInput(new Point(20, 190),
//                    isPassword: true);
//                var comboBox = InputControlFactory.CreateComboBox(new Point(20, 220),
//                    items: new[] { "Option 1", "Option 2", "Option 3" });
//                var datePicker = InputControlFactory.CreateDatePicker(new Point(20, 250));
//                var multiLineText = InputControlFactory.CreateMultiLineTextInput(new Point(20, 280),
//                    new Size(300, 60), "Enter description...");
//                var checkBox = InputControlFactory.CreateCheckBox("I agree to terms", new Point(20, 350));

//                parentForm.Controls.AddRange(new Control[] {
//                textInput, passwordInput, comboBox, datePicker, multiLineText, checkBox
//            });
//            }
//        }
//    }
//}

