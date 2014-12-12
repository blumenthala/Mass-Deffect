using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace MassEffectMap.cs
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class Normandy : Microsoft.Xna.Framework.GameComponent
    {
        public Normandy(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.

        private void HandleKeyboardInput(KeyboardState keyState)
        {
            if (keyState.IsKeyDown(Keys.Up))
            {
                normandyShip.Velocity += new Vector2(0, -1);
            }

            if (keyState.IsKeyDown(Keys.Down))
            {
                normandyShip.Velocity += new Vector2(0, 1);
            }

            if (keyState.IsKeyDown(Keys.Left))
            {
                normandyShip.Velocity += new Vector2(-1, 0);
            }

            if (keyState.IsKeyDown(Keys.Right))
            {
                normandyShip.Velocity += new Vector2(1, 0);
            }
        }

     

        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            base.Update(gameTime);
        }
    }
}
