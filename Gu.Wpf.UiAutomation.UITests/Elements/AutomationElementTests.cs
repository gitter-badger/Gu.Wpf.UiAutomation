﻿namespace Gu.Wpf.UiAutomation.UiTests.Elements
{
    using System;
    using System.Drawing;
    using System.Windows;
    using NUnit.Framework;

    public partial class AutomationElementTests
    {
        private const string ExeFileName = "WpfApplication.exe";

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Application.KillLaunched(ExeFileName);
        }

        [Test]
        public void Parent()
        {
            using (var app = Application.AttachOrLaunch(ExeFileName, "CheckBoxWindow"))
            {
                var window = app.MainWindow;
                var checkBox = window.FindCheckBox();
                Assert.AreEqual("Window", checkBox.Parent.ClassName);
            }
        }

        [Test]
        public void Window()
        {
            using (var app = Application.AttachOrLaunch(ExeFileName, "CheckBoxWindow"))
            {
                var window = app.MainWindow;
                var checkBox = window.FindCheckBox();
                Assert.AreEqual("Window", checkBox.Window.ClassName);
                Assert.AreEqual(true, checkBox.Window.IsMainWindow);
            }
        }

        [Test]
        public void IsKeyboardFocusable()
        {
            using (var app = Application.AttachOrLaunch(ExeFileName, "TextBoxWindow"))
            {
                var window = app.MainWindow;
                var textBox = window.FindTextBox();
                Assert.AreEqual(true, textBox.IsKeyboardFocusable);
            }
        }

        [Test]
        public void HasKeyboardFocus()
        {
            using (var app = Application.AttachOrLaunch(ExeFileName, "TextBoxWindow"))
            {
                var window = app.MainWindow;
                var textBox = window.FindTextBox();
                Assert.AreEqual(false, textBox.HasKeyboardFocus);

                textBox.Click();
                Assert.AreEqual(true, textBox.HasKeyboardFocus);

                Keyboard.ClearFocus();
            }
        }

        [Test]
        public void Size()
        {
            using (var app = Application.AttachOrLaunch(ExeFileName, "SizeWindow"))
            {
                var window = app.MainWindow;
                var button = window.FindButton("SizeButton");
                Assert.AreEqual(200, button.ActualWidth);
                Assert.AreEqual(100, button.ActualHeight);
                Assert.AreEqual(new Rect(50, 112, 200, 100), button.RenderBounds);
                Assert.IsInstanceOf<Rect>(button.Bounds);
            }
        }

        [Test]
        public void DrawHighlight()
        {
            using (var app = Application.AttachOrLaunch(ExeFileName, "SizeWindow"))
            {
                var window = app.MainWindow;
                var button = window.FindButton("SizeButton");
                button.DrawHighlight();
                Wait.For(TimeSpan.FromMilliseconds(500));
            }
        }

        [Test]
        public void DrawHighlightBlocking()
        {
            using (var app = Application.AttachOrLaunch(ExeFileName, "SizeWindow"))
            {
                var window = app.MainWindow;
                var button = window.FindButton("SizeButton");
                button.DrawHighlight(blocking: true, color: Color.Blue, duration: TimeSpan.FromMilliseconds(500));
            }
        }
    }
}