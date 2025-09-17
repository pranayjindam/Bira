using ReaLTaiizor.Colors;
using ReaLTaiizor.Enum.Metro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bira.UI
{
    public class UIControls
    {
        /// <summary>
        /// /// Factory class for creating standardized UI controls for Bira application
        /// </summary>
        public static class UIControlFactory
        {
            // Default styling constants
            private static readonly Color DefaultButtonColor = Color.FromArgb(0, 123, 255);
            private static readonly Color DefaultButtonHoverColor = Color.FromArgb(0, 86, 179);
            private static readonly Color DefaultHeaderColor = Color.FromArgb(52, 58, 64);
            private static readonly Font DefaultButtonFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            private static readonly Font DefaultHeaderFont = new Font("Segoe UI", 14F, FontStyle.Bold);

            /// <summary>
            /// Creates a standardized input button with consistent styling
            /// </summary>
            /// <param name="text">Button text</param>
            /// <param name="location">Button location</param>
            /// <param name="size">Button size (optional)</param>
            /// <param name="clickHandler">Click event handler (optional)</param>
            /// <returns>Configured Button control</returns>
            public static Button CreateInputButton(string text,  Size? size = null, EventHandler clickHandler = null)
            {
                var button = new Button
                {
                    Text = text,

                    Size = size ?? new Size(120, 35),
                    BackColor = DefaultButtonColor,
                    ForeColor = Color.White,
                    Font = DefaultButtonFont,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand,
                    UseVisualStyleBackColor = false
                };

                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = DefaultButtonHoverColor;

                if (clickHandler != null)
                {
                    button.Click += clickHandler;
                }

                // Add hover effects
                button.MouseEnter += (s, e) => button.BackColor = DefaultButtonHoverColor;
                button.MouseLeave += (s, e) => button.BackColor = DefaultButtonColor;

                return button;
            }

            /// <summary>
            /// Creates a primary action button with emphasized styling
            /// </summary>
            /// <param name="text">Button text</param>
            /// <param name="location">Button location</param>
            /// <param name="size">Button size (optional)</param>
            /// <param name="clickHandler">Click event handler (optional)</param>
            /// <returns>Configured primary Button control</returns>
            public static Button CreatePrimaryButton(string text, Size? size = null, EventHandler clickHandler = null)
            {
                var button = CreateInputButton(text, size, clickHandler);
                button.BackColor = Color.FromArgb(40, 167, 69);
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 142, 58);

                button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(34, 142, 58);
                button.MouseLeave += (s, e) => button.BackColor = Color.FromArgb(40, 167, 69);

                return button;
            }

            /// <summary>
            /// Creates a secondary action button with subtle styling
            /// </summary>
            /// <param name="text">Button text</param>
            /// <param name="location">Button location</param>
            /// <param name="size">Button size (optional)</param>
            /// <param name="clickHandler">Click event handler (optional)</param>
            /// <returns>Configured secondary Button control</returns>
            public static Button CreateSecondaryButton(string text, Size? size = null, EventHandler clickHandler = null)
            {
                var button = CreateInputButton(text,  size, clickHandler);
                button.BackColor = Color.FromArgb(108, 117, 125);
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 98, 104);

                button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(90, 98, 104);
                button.MouseLeave += (s, e) => button.BackColor = Color.FromArgb(108, 117, 125);

                return button;
            }

            /// <summary>
            /// Creates a standardized label header with consistent styling
            /// /// </summary>
            /// <param name="text">Header text</param>
            /// <param name="location">Header location</param>
            /// <param name="size">Header size (optional)</param>
            /// <param name="fontSize">Font size (optional, default 14)</param>
            /// <returns>Configured Label control</returns>
            public static Label CreateLabelHeader(string text, Color? foreColor = null, Size? size = null, float fontSize = 18F)
            {
                var label = new Label
                {
                    Text = text,
                    Size = size ?? new Size(400, 45),
                    Font = new Font("Segoe UI", fontSize, FontStyle.Bold),
                    ForeColor = DefaultHeaderColor,
                    AutoSize = size == null
                };

                return label;
            }

            /// <summary>
            /// Creates a subtitle label with medium emphasis
            /// </summary>
            /// <param name="text">Subtitle text</param>
            /// <param name="location">Subtitle location</param>
            /// <param name="size">Subtitle size (optional)</param>
            /// <returns>Configured Label control</returns>
            public static Label CreateSubtitleLabel(string text, Point location, Size? size = null)
            {
                var label = new Label
                {
                    Text = text,
                    Location = location,
                    Size = size ?? new Size(150, 20),
                    Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(73, 80, 87),
                    AutoSize = size == null
                };

                return label;
            }

            /// <summary>
            /// Creates a regular text label
            /// </summary>
            /// <param name="text">Label text</param>
            /// <param name="location">Label location</param>
            /// <param name="size">Label size (optional)</param>
            /// <returns>Configured Label control</returns>
            public static Label CreateTextLabel(string text, Color? forecolor=null, Size? size = null, FontStyle fontStyle = FontStyle.Regular)
            {
                var label = new Label
                {
                    Text = text,
                    Size = size ?? new Size(120, 18),
                    Font = new Font("Segoe UI", 9F, fontStyle),
                    ForeColor = forecolor ?? Color.FromArgb(33, 37, 41),
                    AutoSize = size == null
                };

                return label;
            }

            public static LinkLabel CreateLinkLabel(string text,Color? foreColor = null,LinkLabelLinkClickedEventHandler? linkClickedHandler = null)
            {
                var linkLabel = new LinkLabel
                {
                    Text = text,
                    AutoSize = true,
                    Cursor = Cursors.Hand,
                    ForeColor = foreColor ?? Color.White,
                    LinkColor = foreColor ?? Color.White,
                    
                };

                if (linkClickedHandler != null)
                {
                    linkLabel.LinkClicked += linkClickedHandler;
                }

                return linkLabel;
            }
        }
    }
}
    