using System;

namespace Bira.UI
{
    public class InputControls
    {

        /// <summary>
        /// Factory class for creating standardized input controls for Bira application
        /// </summary>
        public static class InputControlFactory
        {
            private static readonly Font DefaultInputFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            private static readonly Color DefaultBorderColor = Color.FromArgb(206, 212, 218);
            private static readonly Color FocusBorderColor = Color.FromArgb(0, 123, 255);

            /// <summary>
            /// Creates a standardized text input with validation styling
            /// </summary>
            /// <param name="location">TextBox location</param>
            /// <param name="size">TextBox size (optional)</param>
            /// <param name="placeholder">Placeholder text (optional)</param>
            /// <param name="isPassword">Whether this is a password field</param>
            /// <returns>Configured TextBox control</returns>
            public static TextBox CreateTextInput(Size? size = null, string placeholder = "", bool isPassword = false)
            {

                var textBox = new TextBox
                {
                    Size = size ?? new Size(200, 25),
                    Font = DefaultInputFont,
                    BorderStyle = BorderStyle.FixedSingle,
                    UseSystemPasswordChar = isPassword
                };
                if (!string.IsNullOrEmpty(placeholder))
                {
                    SetPlaceholder(textBox, placeholder);
                }



                // Add focus styling
                textBox.Enter += (s, e) => textBox.BackColor = Color.FromArgb(248, 249, 250);
                textBox.Leave += (s, e) => textBox.BackColor = Color.White;

                return textBox;
            }

            /// <summary>
            /// Creates a standardized ComboBox with consistent styling
            /// </summary>
            /// <param name="location">ComboBox location</param>
            /// <param name="size">ComboBox size (optional)</param>
            /// <param name="items">Items to populate (optional)</param>
            /// <returns>Configured ComboBox control</returns>
            public static ComboBox CreateComboBox(Point location, Size? size = null, string[] items = null)
            {
                var comboBox = new ComboBox
                {
                    Location = location,
                    Size = size ?? new Size(200, 25),
                    Font = DefaultInputFont,
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    FlatStyle = FlatStyle.Flat
                };

                if (items != null)
                {
                    comboBox.Items.AddRange(items);
                }

                return comboBox;
            }

            /// <summary>
            /// Creates a standardized DateTimePicker
            /// </summary>
            /// <param name="location">DateTimePicker location</param>
            /// <param name="size">DateTimePicker size (optional)</param>
            /// <param name="format">Date format (optional)</param>
            /// <returns>Configured DateTimePicker control</returns>
            public static DateTimePicker CreateDatePicker(Point location, Size? size = null, DateTimePickerFormat format = DateTimePickerFormat.Short)
            {
                var datePicker = new DateTimePicker
                {
                    Location = location,
                    Size = size ?? new Size(200, 25),
                    Font = DefaultInputFont,
                    Format = format
                };

                return datePicker;
            }

            /// <summary>
            /// Creates a standardized multi-line text input
            /// </summary>
            /// <param name="location">TextBox location</param>
            /// <param name="size">TextBox size (optional)</param>
            /// <param name="placeholder">Placeholder text (optional)</param>
            /// <returns>Configured multi-line TextBox control</returns>
            public static TextBox CreateMultiLineTextInput(Point location, Size? size = null, string placeholder = "")
            {
                var textBox = new TextBox
                {
                    Location = location,
                    Size = size ?? new Size(300, 80),
                    Font = DefaultInputFont,
                    BorderStyle = BorderStyle.FixedSingle,
                    Multiline = true,
                    ScrollBars = ScrollBars.Vertical
                };

                if (!string.IsNullOrEmpty(placeholder))
                {
                    SetPlaceholder(textBox, placeholder);
                }

                // Add focus styling
                textBox.Enter += (s, e) => textBox.BackColor = Color.FromArgb(248, 249, 250);
                textBox.Leave += (s, e) => textBox.BackColor = Color.White;

                return textBox;
            }

            /// <summary>
            /// Creates a standardized CheckBox
            /// </summary>
            /// <param name="text">CheckBox text</param>
            /// <param name="location">CheckBox location</param>
            /// <param name="size">CheckBox size (optional)</param>
            /// <returns>Configured CheckBox control</returns>
            public static CheckBox CreateCheckBox(string text, Point location, Size? size = null)
            {
                var checkBox = new CheckBox
                {
                    Text = text,
                    Location = location,
                    Size = size ?? new Size(150, 20),
                    Font = DefaultInputFont,
                    UseVisualStyleBackColor = true
                };

                return checkBox;
            }

            /// <summary>
            /// Sets placeholder text for a TextBox
            /// </summary>
            /// <param name="textBox">Target TextBox</param>
            /// <param name="placeholder">Placeholder text</param>
            private static void SetPlaceholder(TextBox textBox, string placeholder)
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;

                textBox.Enter += (s, e) =>
                {
                    if (textBox.Text == placeholder)
                    {
                        textBox.Text = "";
                        textBox.ForeColor = Color.Black;
                    }
                };

                textBox.Leave += (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Text = placeholder;
                        textBox.ForeColor = Color.Gray;
                    }
                };
            }

            /// <summary>
            /// Applies validation styling to a control
            /// </summary>
            /// <param name="control">Control to style</param>
            /// <param name="isValid">Whether the input is valid</param>
            /// <param name="toolTip">ToolTip control for error messages</param>
            /// <param name="errorMessage">Error message to display</param>
            public static void ApplyValidationStyling(Control control, bool isValid, ToolTip toolTip = null, string errorMessage = "")
            {
                if (isValid)
                {
                    control.BackColor = Color.LightGreen;
                    toolTip?.SetToolTip(control, "Valid input");
                }
                else
                {
                    control.BackColor = Color.LightCoral;
                    toolTip?.SetToolTip(control, errorMessage);
                }
            }

           
        }
    }
}

