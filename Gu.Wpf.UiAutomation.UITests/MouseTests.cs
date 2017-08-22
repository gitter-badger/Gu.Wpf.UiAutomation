﻿using System.Threading;
using Gu.Wpf.UiAutomation.Input;
using Gu.Wpf.UiAutomation.Shapes;
using Gu.Wpf.UiAutomation.UITests.TestFramework;
using Gu.Wpf.UiAutomation.UIA3;
using NUnit.Framework;

namespace Gu.Wpf.UiAutomation.UITests
{
    [TestFixture]
    public class MouseTests
    {
        [Test]
        public void MoveTest()
        {
            Mouse.Position = new Point(0, 0);
            Mouse.MoveBy(800, 0);
            Mouse.MoveBy(0, 400);
            Mouse.MoveBy(-400, -200);
        }

        [Test]
        public void ClickTest()
        {
            var app = Application.Launch("mspaint");
            using (var automation = new UIA3Automation())
            {
                var mainWindow = app.GetMainWindow(automation);
                var mouseX = mainWindow.Properties.BoundingRectangle.Value.Left + 50;
                var mouseY = mainWindow.Properties.BoundingRectangle.Value.Top + 200;
                Mouse.Position = new Point(mouseX, mouseY);
                Mouse.Down(MouseButton.Left);
                Mouse.MoveBy(100, 10);
                Mouse.MoveBy(10, 50);
                Mouse.Up(MouseButton.Left);
                Thread.Sleep(500);
                TestUtilities.CloseWindowWithDontSave(mainWindow);
            }
            app.Dispose();
        }
    }
}