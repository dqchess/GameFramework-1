﻿//----------------------------------------------
// Flip Web Apps: Game Framework
// Copyright © 2016 Flip Web Apps / Mark Hewitt
//----------------------------------------------

using FlipWebApps.GameFramework.Scripts.GameStructure;

namespace FlipWebApps.GameFramework.Scripts.Input.Components
{
    /// <summary>
    /// Loads the given level when a mouse button is pressed or the screen is tapped anywhere on teh screen
    /// 
    /// By setting a list of UI game objects you can set areas that wonwill block the change.
    /// </summary>
    public class OnMouseClickOrTapLoadLevel : OnMouseClickOrTap
    {
        public string SceneName;

        public override void RunMethod() {
            // if we got here then load the new scene
            GameManager.LoadSceneWithTransitions(SceneName);
        }
    }
}