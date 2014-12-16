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
    public class Normandy
    {
        Texture2D Mormandy;
        Sprite norman;
        private Normandy normandy;
        public Normandy(Texture2D text)
        {
            Mormandy = text;
            norman = new Sprite(new Vector2(300, 300), Mormandy, new Rectangle(0, 0, 194, 672), Vector2.Zero);
        }

      

        private void HandleKeyboardInput(KeyboardState keyState)
        {
            if (keyState.IsKeyDown(Keys.Up))
            {
                norman.Velocity += new Vector2(0, -1);
            }

            if (keyState.IsKeyDown(Keys.Down))
            {
                norman.Velocity += new Vector2(0, 1);
            }

            if (keyState.IsKeyDown(Keys.Left))
            {
                norman.Velocity += new Vector2(-1, 0);
            }

            if (keyState.IsKeyDown(Keys.Right))
            {
                norman.Velocity += new Vector2(1, 0);
            }
        }

     

        /// </summary>
        public void draw(SpriteBatch spritebatch)
        {
            norman.Draw(spritebatch);
        }
        public void Update(GameTime gameTime)
        {

            norman.Update(gameTime);
        }
    }
}
