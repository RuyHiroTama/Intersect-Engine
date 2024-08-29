using System;
using System.Collections.Generic;
using System.Numerics;
using Intersect.Client.Core;
using Intersect.Client.Core.Controls;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.GenericClasses;
using Intersect.Client.Framework.Graphics;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.GameObjects;
using Intersect.Logging;

namespace Intersect.Client.Interface.Game.MiniEvent
{
    public partial class FishEventUI
    {
        private ImagePanel root;

        private ImagePanel fishEventPanel;
        private ImagePanel rangeMoveFrame;
        private ImagePanel rangeMoveAnchorFiller;
        private ImagePanel rangeMoveFiller;

        private ImagePanel playerHook;

        private ImagePanel progressBarFrame;
        private ImagePanel progressBarAnchorFiller;
        private ImagePanel progressBarFiller;

        private ImagePanel Success;
        private ImagePanel ItemViewer;
        private ImagePanel Failed;
        private Label SuccessText;
        //private Label FailedText;

        public FishEventUI()
        {
            Canvas gameCanvas = Interface.GameUi.GameCanvas;

            #region root
            root = new ImagePanel(gameCanvas, "FishEventUI");
            root.SetBounds(0, 0, 512, 168);
            root.Padding = new Framework.Gwen.Padding(0, 0, 0, 0);
            root.AlignmentDistance = new Framework.Gwen.Padding(0, 0, 0, 0);
            root.AlignmentTransform = new Point(0, -300);
            root.Margin = new Framework.Gwen.Margin(0, 0, 0, 0);
            root.RenderColor = new Color(255,255, 255, 255);
            root.AddAlignment(Alignments.Center);
            root.ShouldDrawBackground = true;
            root.MinimumSize = new Point(1, 1);
            root.MaximumSize = new Point(4096, 4096);
            root.IsDisabled = false;
            root.IsHidden = false;
            root.RestrictToParent = false;
            root.MouseInputEnabled = false;
            root.TextureFilename = "";
            #endregion

            #region main Panel
            fishEventPanel = new ImagePanel(root, "MainPanel");
            fishEventPanel.SetBounds(0, 0, 512, 168);
            fishEventPanel.Padding = new Framework.Gwen.Padding(0, 0, 0, 0);
            fishEventPanel.AlignmentDistance = new Framework.Gwen.Padding(0, 0, 0, 0);
            fishEventPanel.AlignmentTransform = new Point(0, 0);
            fishEventPanel.Margin = new Framework.Gwen.Margin(0, 0, 0, 0);
            fishEventPanel.RenderColor = new Color(255, 255, 255, 255);
            fishEventPanel.AddAlignment(Alignments.Center);
            fishEventPanel.ShouldDrawBackground = true;
            fishEventPanel.MinimumSize = new Point(1, 1);
            fishEventPanel.MaximumSize = new Point(4096, 4096);
            fishEventPanel.IsDisabled = false;
            fishEventPanel.IsHidden = false;
            fishEventPanel.RestrictToParent = false;
            fishEventPanel.MouseInputEnabled = false;
            fishEventPanel.TextureFilename = "fish_background.png";
            #endregion

            #region Позиция рыбки

            #region MoveRange
            rangeMoveFrame = new ImagePanel(fishEventPanel, "MoveRange");
            rangeMoveFrame.SetBounds(24, 96, 464, 48);
            rangeMoveFrame.Padding = new Framework.Gwen.Padding(0, 0, 0, 0);
            rangeMoveFrame.AlignmentDistance = new Framework.Gwen.Padding(0, 0, 0, 0);
            rangeMoveFrame.AlignmentTransform = new Point(0, 36);
            rangeMoveFrame.Margin = new Framework.Gwen.Margin(0, 0, 0, 0);
            rangeMoveFrame.RenderColor = new Color(255, 255, 255, 255);
            rangeMoveFrame.AddAlignment(Alignments.Center);
            rangeMoveFrame.ShouldDrawBackground = true;
            rangeMoveFrame.MinimumSize = new Point(1, 1);
            rangeMoveFrame.MaximumSize = new Point(4096, 4096);
            rangeMoveFrame.IsDisabled = false;
            rangeMoveFrame.IsHidden = false;
            rangeMoveFrame.RestrictToParent = true;
            rangeMoveFrame.MouseInputEnabled = false;
            rangeMoveFrame.TextureFilename = "fish_backlayer.png";
            #endregion
            #region AnchorFiller
            rangeMoveAnchorFiller = new ImagePanel(rangeMoveFrame, "rangeMoveAnchorFiller");
            rangeMoveAnchorFiller.SetBounds(0, 0, 464, 48);
            rangeMoveAnchorFiller.Padding = new Framework.Gwen.Padding(0, 0, 0, 0);
            rangeMoveAnchorFiller.AlignmentDistance = new Framework.Gwen.Padding(0, 0, 0, 0);
            rangeMoveAnchorFiller.AlignmentTransform = new Point(0, 0);
            rangeMoveAnchorFiller.Margin = new Framework.Gwen.Margin(0, 0, 0, 0);
            rangeMoveAnchorFiller.RenderColor = new Color(255, 255, 255, 255);
            rangeMoveAnchorFiller.AddAlignment(Alignments.Center);
            rangeMoveAnchorFiller.ShouldDrawBackground = true;
            rangeMoveAnchorFiller.MinimumSize = new Point(1, 1);
            rangeMoveAnchorFiller.MaximumSize = new Point(4096, 4096);
            rangeMoveAnchorFiller.IsDisabled = false;
            rangeMoveAnchorFiller.IsHidden = false;
            rangeMoveAnchorFiller.RestrictToParent = true;
            rangeMoveAnchorFiller.MouseInputEnabled = false;
            rangeMoveAnchorFiller.TextureFilename = "";
            #endregion
            #region Frame
            rangeMoveFiller = new ImagePanel(rangeMoveFrame, "MoveFiller");
            rangeMoveFiller.SetBounds(198, 2, 68, 44);
            rangeMoveFiller.Padding = new Framework.Gwen.Padding(0, 0, 0, 0);
            rangeMoveFiller.AlignmentDistance = new Framework.Gwen.Padding(0, 0, 0, 0);
            rangeMoveFiller.AlignmentTransform = new Point(0, 0);
            rangeMoveFiller.Margin = new Framework.Gwen.Margin(0, 0, 0, 0);
            rangeMoveFiller.RenderColor = new Color(255, 255, 255, 255);
            rangeMoveFiller.AddAlignment(Alignments.Center);
            rangeMoveFiller.ShouldDrawBackground = true;
            rangeMoveFiller.MinimumSize = new Point(1, 1);
            rangeMoveFiller.MaximumSize = new Point(4096, 4096);
            rangeMoveFiller.IsDisabled = false;
            rangeMoveFiller.IsHidden = false;
            rangeMoveFiller.RestrictToParent = true;
            rangeMoveFiller.MouseInputEnabled = false;
            rangeMoveFiller.TextureFilename = "fish_filler.png";
            #endregion

            #region Крючок
            playerHook = new ImagePanel(rangeMoveFrame, "MoveForce");
            playerHook.SetBounds(208, 0, 48, 48);
            playerHook.Padding = new Framework.Gwen.Padding(0, 0, 0, 0);
            playerHook.AlignmentDistance = new Framework.Gwen.Padding(0, 0, 0, 0);
            playerHook.AlignmentTransform = new Point(0, 0);
            playerHook.Margin = new Framework.Gwen.Margin(0, 0, 0, 0);
            playerHook.RenderColor = new Color(255, 255, 255, 255);
            playerHook.AddAlignment(Alignments.Center);
            playerHook.ShouldDrawBackground = true;
            playerHook.MinimumSize = new Point(1, 1);
            playerHook.MaximumSize = new Point(4096, 4096);
            playerHook.IsDisabled = false;
            playerHook.IsHidden = false;
            playerHook.RestrictToParent = true;
            playerHook.MouseInputEnabled = false;
            playerHook.TextureFilename = "fish_force.png";
            #endregion

            #endregion

            #region Прогресс

            #region ProgressBar
            progressBarFrame = new ImagePanel(fishEventPanel, "ProgressBarFrame");
            progressBarFrame.SetBounds(24, 24, 464, 48);
            progressBarFrame.Padding = new Framework.Gwen.Padding(0, 0, 0, 0);
            progressBarFrame.AlignmentDistance = new Framework.Gwen.Padding(0, 0, 0, 0);
            progressBarFrame.AlignmentTransform = new Point(0, -36);
            progressBarFrame.Margin = new Framework.Gwen.Margin(0, 0, 0, 0);
            progressBarFrame.RenderColor = new Color(255, 255, 255, 255);
            progressBarFrame.AddAlignment(Alignments.Center);
            progressBarFrame.ShouldDrawBackground = true;
            progressBarFrame.MinimumSize = new Point(1, 1);
            progressBarFrame.MaximumSize = new Point(4096, 4096);
            progressBarFrame.IsDisabled = false;
            progressBarFrame.IsHidden = false;
            progressBarFrame.RestrictToParent = true;
            progressBarFrame.MouseInputEnabled = false;
            progressBarFrame.TextureFilename = "fish_test1.png";
            #endregion
            #region AnchorFiller
            progressBarAnchorFiller = new ImagePanel(progressBarFrame, "ProgressBarAnchorFiller");
            progressBarAnchorFiller.SetBounds(0, 0, 464, 48);
            progressBarAnchorFiller.Padding = new Framework.Gwen.Padding(0, 0, 0, 0);
            progressBarAnchorFiller.AlignmentDistance = new Framework.Gwen.Padding(0, 0, 0, 0);
            progressBarAnchorFiller.AlignmentTransform = new Point(0, 0);
            progressBarAnchorFiller.Margin = new Framework.Gwen.Margin(0, 0, 0, 0);
            progressBarAnchorFiller.RenderColor = new Color(255, 255, 255, 255);
            progressBarAnchorFiller.AddAlignment(Alignments.Center);
            progressBarAnchorFiller.ShouldDrawBackground = true;
            progressBarAnchorFiller.MinimumSize = new Point(1, 1);
            progressBarAnchorFiller.MaximumSize = new Point(4096, 4096);
            progressBarAnchorFiller.IsDisabled = false;
            progressBarAnchorFiller.IsHidden = false;
            progressBarAnchorFiller.RestrictToParent = true;
            progressBarAnchorFiller.MouseInputEnabled = false;
            progressBarAnchorFiller.TextureFilename = "";
            #endregion
            #region Filler
            progressBarFiller = new ImagePanel(progressBarFrame, "ProgressBarFiller");
            progressBarFiller.SetBounds(0, 0, 464, 48);
            progressBarFiller.Padding = new Framework.Gwen.Padding(0, 0, 0, 0);
            progressBarFiller.AlignmentDistance = new Framework.Gwen.Padding(0, 0, 0, 0);
            progressBarFiller.AlignmentTransform = new Point(0, 0);
            progressBarFiller.Margin = new Framework.Gwen.Margin(0, 0, 0, 0);
            progressBarFiller.RenderColor = new Color(255, 255, 255, 255);
            progressBarFiller.AddAlignment(Alignments.Center);
            progressBarFiller.ShouldDrawBackground = true;
            progressBarFiller.MinimumSize = new Point(1, 1);
            progressBarFiller.MaximumSize = new Point(4096, 4096);
            progressBarFiller.IsDisabled = false;
            progressBarFiller.IsHidden = false;
            progressBarFiller.RestrictToParent = true;
            progressBarFiller.MouseInputEnabled = false;
            progressBarFiller.TextureFilename = "fish_test2.png";
            #endregion

            #endregion

            #region Success
            Success = new ImagePanel(root, "Success");
            Success.SetBounds(160, 0, 192, 168);
            Success.Padding = new Framework.Gwen.Padding(0, 0, 0, 0);
            Success.AlignmentDistance = new Framework.Gwen.Padding(0, 0, 0, 0);
            Success.AlignmentTransform = new Point(0, 0);
            Success.Margin = new Framework.Gwen.Margin(0, 0, 0, 0);
            Success.RenderColor = new Color(255, 255, 255, 255);
            Success.AddAlignment(Alignments.Center);
            Success.ShouldDrawBackground = true;
            Success.MinimumSize = new Point(1, 1);
            Success.MaximumSize = new Point(4096, 4096);
            Success.IsDisabled = false;
            Success.IsHidden = false;
            Success.RestrictToParent = true;
            Success.MouseInputEnabled = false;
            Success.TextureFilename = "fish_sussess.png";
            
            ItemViewer = new ImagePanel(Success, "ItemViewer");
            ItemViewer.SetBounds(72, 48, 48, 48);
            ItemViewer.Padding = new Framework.Gwen.Padding(0, 0, 0, 0);
            ItemViewer.AlignmentDistance = new Framework.Gwen.Padding(0, 0, 0, 0);
            ItemViewer.AlignmentTransform = new Point(0, 0);
            ItemViewer.Margin = new Framework.Gwen.Margin(0, 0, 0, 0);
            ItemViewer.RenderColor = new Color(255, 255, 255, 255);
            ItemViewer.AddAlignment(Alignments.Center);
            ItemViewer.ShouldDrawBackground = true;
            ItemViewer.MinimumSize = new Point(1, 1);
            ItemViewer.MaximumSize = new Point(4096, 4096);
            ItemViewer.IsDisabled = false;
            ItemViewer.IsHidden = false;
            ItemViewer.RestrictToParent = true;
            ItemViewer.MouseInputEnabled = false;
            ItemViewer.TextureFilename = "";

            SuccessText = new Label(Success, "SuccessText");
            SuccessText.Text = "You got the fish!";
            SuccessText.SetBounds(37, 119, 117, 20);
            SuccessText.Padding = new Framework.Gwen.Padding(0, 0, 0, 0);
            SuccessText.AlignmentDistance = new Framework.Gwen.Padding(0, 0, 0, 0);
            SuccessText.AlignmentTransform = new Point(0, 45);
            SuccessText.Margin = new Framework.Gwen.Margin(0, 0, 0, 0);
            SuccessText.RenderColor = new Color(255, 255, 255, 255);
            SuccessText.AddAlignment(Alignments.Center);
            SuccessText.ShouldDrawBackground = true;
            SuccessText.MinimumSize = new Point(1, 1);
            SuccessText.MaximumSize = new Point(4096, 4096);
            SuccessText.IsDisabled = false;
            SuccessText.IsHidden = false;
            SuccessText.RestrictToParent = true;
            SuccessText.MouseInputEnabled = false;
            SuccessText.TextColor = new Color(255, 255, 255, 255);
            SuccessText.FontName = "sourcesansproblack";
            SuccessText.FontSize = 12;
            SuccessText.SetTextScale(1f);
            SuccessText.Alignment = Pos.Left;
            #endregion

            #region Failed
            Failed = new ImagePanel(root, "Failed");
            Failed.SetBounds(165, 65, 182, 38);
            Failed.Padding = new Framework.Gwen.Padding(0, 0, 0, 0);
            Failed.AlignmentDistance = new Framework.Gwen.Padding(0, 0, 0, 0);
            Failed.AlignmentTransform = new Point(0, 0);
            Failed.Margin = new Framework.Gwen.Margin(0, 0, 0, 0);
            Failed.RenderColor = new Color(255, 255, 255, 255);
            Failed.AddAlignment(Alignments.Center);
            Failed.ShouldDrawBackground = true;
            Failed.MinimumSize = new Point(1, 1);
            Failed.MaximumSize = new Point(4096, 4096);
            Failed.IsDisabled = false;
            Failed.IsHidden = false;
            Failed.RestrictToParent = true;
            Failed.MouseInputEnabled = false;
            Failed.TextureFilename = "smallbutton_clicked.png";
            #endregion

            
            root.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
            Hide();
        }

        public bool IsVisible => !fishEventPanel.IsHidden;
        public void Show()
        {
            root.Show();
            rangeMoveFrame.Show();
            playerHook.Show();
            progressBarFrame.Show();
            fishEventPanel.Show();
        }
        public void Hide()
        {
            root.Hide();
        }
        public void HideBars(){
            rangeMoveFrame.Hide();
            playerHook.Hide();
            progressBarFrame.Hide();
            fishEventPanel.Hide();
        }
        public void ShowSuccess() =>Success.Show();
        public void HideSuccess() =>Success.Hide();
        public void ShowFailed() => Failed.Show();
        public void HideFailed() => Failed.Hide();


        public void RedrawIcon(ItemBase item)
        {
            var itemTex = Globals.ContentManager.GetTexture(Framework.Content.TextureType.Item, item.Icon);
            ItemViewer.Texture = itemTex;

            SuccessText.Text = $"{item.Name}";
        }

        public void RangeMoveResize(float valuePosition, float valueSize)
        {          
            valuePosition = Math.Clamp(valuePosition, 0, 1);
            valueSize = Math.Clamp(valueSize, 0, 1);

            int width = (int)(rangeMoveAnchorFiller.Width * valueSize);
            int x = (int)(rangeMoveAnchorFiller.Width * valuePosition - width/2f);
            
            rangeMoveFiller.SetBounds(new Rectangle(rangeMoveAnchorFiller.X + x, rangeMoveAnchorFiller.Y, width, rangeMoveFiller.Height));
        }

        public void PlayerForceMoved(float valuePosition, float valueSize)
        {        
            valuePosition = Math.Clamp(valuePosition, 0, 1);
            valueSize = Math.Clamp(valueSize, 0, 1);

            int width = (int)(rangeMoveAnchorFiller.Width * valueSize);
            int x = (int)(rangeMoveAnchorFiller.Width * valuePosition - width / 2f);

            playerHook.SetBounds(new Rectangle(rangeMoveAnchorFiller.X + x, rangeMoveAnchorFiller.Y, width, playerHook.Height));
        }

        public void Progress(float valueProgress)
        {

            valueProgress = Math.Clamp(valueProgress, 0, 1);

            int width = (int)(progressBarAnchorFiller.Width * valueProgress);
            //int x = (int)(rangeMoveAnchorFiller.Width * valuePosition - width / 2f);

            progressBarFiller.SetBounds(new Rectangle(progressBarFiller.X, progressBarFiller.Y, width, progressBarFiller.Height));

            //label1.Text = $"position({valuePosition.ToString("0.00f")})  size({valueSize.ToString("0.00f")})";

        }


    }
}