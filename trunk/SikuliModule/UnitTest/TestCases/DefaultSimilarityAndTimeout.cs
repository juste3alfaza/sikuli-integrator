﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SikuliModule;
using UnitTest.Core;

namespace UnitTest.TestCases
{
    [TestClass]
    public class DefaultSimilarityAndTimeout : BaseTestCase
    {
        [TestMethod,
        Description("Test Exists mechanism - default similarity and timeout")]
        public void TestExistsDefault()
        {
            if (SikuliAction.Exists(pattern).IsEmpty)
            {
                Report.Error("Nope! It's gone...");
            }
            else
            {
                Report.Pass("Yep! It's there...");
            }
        }

        [TestMethod,
        Description("Test Find All mechanism - default similarity and timeout")]
        public void TestFindAllDefault()
        {
            //There are 3 patterns on the test image
            List<Point> points = SikuliAction.FindAll(findAllPattern);
            if (points != null &&
                points.Count == 3)
            {
                foreach (Point point in points)
                {
                    Report.Info("X:" + point.X + "  Y: " + point.Y);
                }
                Report.Pass("Yep! They are 3...");
            }
            else
            {
                Report.Error("Nope! They are NOT 3...");
            }
        }

        [TestMethod,
        Description("Test Click mechanism - default similarity and timeout")]
        public void TestClickDefault()
        {
            try
            {
                SikuliAction.Click(pattern);
                Report.Pass("Yep! It's clicked...");
            }
            catch
            {
                Report.Error("Nope! It's NOT clicked...");
            }
        }

        [TestMethod,
        Description("Test Hover mechanism - default similarity and timeout")]
        public void TestHoverDefault()
        {
            try
            {
                SikuliAction.Hover(pattern);
                Report.Pass("Yep! It's hovered...");
            }
            catch
            {
                Report.Error("Nope! It's NOT hovered...");
            }
        }

        [TestMethod,
        Description("Test Double Click mechanism - default similarity and timeout")]
        public void TestDoubleClickDefault()
        {
            try
            {
                SikuliAction.DoubleClick(extraPattern);
                Report.Pass("Yep! It's double clicked...");
            }
            catch
            {
                Report.Error("Nope! It's NOT double clicked...");
            }
        }

        [TestMethod,
        Description("Test Right Click mechanism - default similarity and timeout")]
        public void TestRightClickDefault()
        {
            try
            {
                SikuliAction.RightClick(pattern);
                Report.Pass("Yep! It's right clicked...");
            }
            catch
            {
                Report.Error("Nope! It's NOT right clicked...");
            }
        }

        [TestMethod,
        Description("Test Drag and Drop mechanism - default similarity and timeout")]
        public void TestDragAndDropDefault()
        {
            try
            {
                SikuliAction.DragAndDrop(extraPattern, pattern);
                Report.Pass("Yep! It's drag and dropped...");
            }
            catch
            {
                Report.Error("Nope! It's NOT drag and dropped...");
            }
        }
    }
}