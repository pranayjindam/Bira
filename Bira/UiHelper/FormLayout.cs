using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bira.UI.InputControls;
using static Bira.UI.UIControls;

namespace Bira.UI
{
    internal class FormLayout
    {
       
        /// <summary>
        /// Helper class for consistent form layouts and spacing
        /// </summary>
        public static class FormLayoutHelper
        {
            // Standard spacing constants
            public const int StandardMargin = 20;
            public const int ControlSpacing = 10;
            public const int SectionSpacing = 25;
            public const int ButtonSpacing = 15;

            /// <summary>
            /// Creates a form input group with label and input control
            /// </summary>
            /// <param name="parent">Parent container</param>
            /// <param name="labelText">Label text</param>
            /// <param name="startLocation">Starting location for the group</param>
            /// <param name="inputType">Type of input control</param>
            /// <param name="inputSize">Size of input control (optional)</param>
            /// <returns>The created input control</returns>
            public static Control CreateInputGroup(Control parent, string labelText, Point startLocation,
                InputType inputType = InputType.TextBox, Size? inputSize = null)
            {
                // Create label
                var label = UIControlFactory.CreateTextLabel(labelText);
                parent.Controls.Add(label);

                // Calculate input position
                var inputLocation = new Point(startLocation.X, startLocation.Y + label.Height + 5);
                Control inputControl = null;

                // Create appropriate input control
                switch (inputType)
                {
                    case InputType.TextBox:
                        inputControl = InputControlFactory.CreateTextInput( inputSize);
                        break;
                    case InputType.Password:
                        inputControl = InputControlFactory.CreateTextInput( inputSize, isPassword: true);
                        break;
                    case InputType.MultiLine:
                        inputControl = InputControlFactory.CreateMultiLineTextInput(inputLocation, inputSize);
                        break;
                    case InputType.ComboBox:
                        inputControl = InputControlFactory.CreateComboBox(inputLocation, inputSize);
                        break;
                    case InputType.DatePicker:
                        inputControl = InputControlFactory.CreateDatePicker(inputLocation, inputSize);
                        break;
                }

                if (inputControl != null)
                {
                    parent.Controls.Add(inputControl);
                }

                return inputControl;
            }

            /// <summary>
            /// Creates a button group with consistent spacing
            /// </summary>
            /// <param name="parent">Parent container</param>
            /// <param name="buttons">Array of button configurations</param>
            /// <param name="startLocation">Starting location for the button group</param>
            /// <param name="alignment">Button alignment</param>
            public static void CreateButtonGroup(Control parent, ButtonConfig[] buttons, Point startLocation,
                ButtonAlignment alignment = ButtonAlignment.Left)
            {
                int currentX = startLocation.X;
                int currentY = startLocation.Y;

                foreach (var config in buttons)
                {
                    Button button = null;

                    switch (config.Type)
                    {
                        case ButtonType.Primary:
                            button = UIControlFactory.CreatePrimaryButton(config.Text,
                                 config.Size,clickHandler: config.ClickHandler);
                            break;
                        case ButtonType.Secondary:
                            button = UIControlFactory.CreateSecondaryButton(config.Text,
                                config.Size, clickHandler: config.ClickHandler);
                            break;
                        default:
                            button = UIControlFactory.CreateInputButton(config.Text,
                                 config.Size, config.ClickHandler);
                            break;
                    }

                    parent.Controls.Add(button);

                    // Update position for next button
                    if (alignment == ButtonAlignment.Horizontal)
                    {
                        currentX += button.Width + ButtonSpacing;
                    }
                    else
                    {
                        currentY += button.Height + ControlSpacing;
                    }
                }
            }

            /// <summary>
            /// Calculates the next control position based on the previous control
            /// </summary>
            /// <param name="previousControl">Previous control</param>
            /// <param name="spacing">Spacing between controls (optional)</param>
            /// <returns>Next control position</returns>
            public static Point GetNextControlPosition(Control previousControl, int spacing = ControlSpacing)
            {
                return new Point(previousControl.Location.X,
                    previousControl.Location.Y + previousControl.Height + spacing);
            }

            /// <summary>
            /// Centers a control horizontally within its parent
            /// </summary>
            /// <param name="control">Control to center</param>
            /// <param name="parent">Parent container</param>
            public static void CenterHorizontally(Control control, Control parent)
            {
                control.Location = new Point(
                    (parent.Width - control.Width) / 2,
                    control.Location.Y
                );
            }

            /// <summary>
            /// Applies consistent form styling
            /// </summary>
            /// <param name="form">Form to style</param>
            /// <param name="title">Form title (optional)</param>
            public static void ApplyFormStyling(Form form, string title = null)
            {
                form.BackColor = Color.White;
                form.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;

                if (!string.IsNullOrEmpty(title))
                {
                    form.Text = title;
                }
            }
        }

        /// <summary>
        /// /// Input control types
        /// </summary>
        public enum InputType
        {
            TextBox,
            Password,
            MultiLine,
            ComboBox,
            DatePicker
        }

        /// <summary>
        /// Button types
        /// </summary>
        public enum ButtonType
        {
            Default,
            Primary,
            Secondary
        }
        /// <summary>
        /// Button alignment options
        /// </summary>
        public enum ButtonAlignment
        {
            Left,
            Horizontal,
            Vertical
        }

        /// <summary>
        /// Button configuration structure
        /// /// </summary>
        public struct ButtonConfig
        {
            public string Text { get; set; }
            public ButtonType Type { get; set; }
            public Size? Size { get; set; }
            public EventHandler ClickHandler { get; set; }

            public ButtonConfig(string text, ButtonType type = ButtonType.Default,
                Size? size = null, EventHandler clickHandler = null)
            {
                Text = text;
                Type = type;
                Size = size;
                ClickHandler = clickHandler;
            }
        }
    }
}

