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
        Texture2D NormandyShip;
        Sprite norman;
        private float playerSpeed = 160.0f;
        private Rectangle playerAreaLimit;
        Rectangle screenBounds;
        

        public Normandy(Texture2D text)
        {
            NormandyShip = text;
            norman = new Sprite(new Vector2(300, 300), NormandyShip, new Rectangle(0, 0, 194, 672), Vector2.Zero);
        }

        public Normandy(
            Texture2D texture,  
            Rectangle initialFrame,
            int frameCount,
            Rectangle screenBounds)
        {
            norman = new Sprite(
                new Vector2(500, 500),
                texture,
                initialFrame,
                Vector2.Zero);

           
            playerAreaLimit =
                new Rectangle(
                    0,
                    screenBounds.Height / 2,
                    screenBounds.Width,
                    screenBounds.Height / 2);
        }
        private void HandleKeyboardInput(KeyboardState keyState)
        {
            if (keyState.IsKeyDown(Keys.Up))
            {
                norman.Velocity += new Vector2(0, -1);
                norman.Rotation = 0.1f;
            }

            if (keyState.IsKeyDown(Keys.Down))
            {
                norman.Velocity += new Vector2(0, 1);
                norman.Rotation = -3.0f;
            }

            if (keyState.IsKeyDown(Keys.Left))
            {
                norman.Velocity += new Vector2(-1, 0);
                norman.Rotation = -1.6f;
            }

            if (keyState.IsKeyDown(Keys.Right))
            {
                norman.Velocity += new Vector2(1, 0);
                norman.Rotation = 1.6f;
            }
        }

        private void HandleGamepadInput(GamePadState gamePadState)
        {
            norman.Velocity +=
                new Vector2(
                    gamePadState.ThumbSticks.Left.X,
                    -gamePadState.ThumbSticks.Left.Y);

        }

        private void imposeMovementLimits()
        {
            Vector2 location = norman.Location;

            if (location.X < playerAreaLimit.X)
                location.X = playerAreaLimit.X;

            if (location.X >
                (playerAreaLimit.Right - norman.Source.Width))
                location.X =
                    (playerAreaLimit.Right - norman.Source.Width);

            if (location.Y < playerAreaLimit.Y)
                location.Y = playerAreaLimit.Y;

            if (location.Y >
                (playerAreaLimit.Bottom - norman.Source.Height))
                location.Y =
                    (playerAreaLimit.Bottom - norman.Source.Height);

            norman.Location = location;
        }
   
       
        public void draw(SpriteBatch spritebatch)
        {
            norman.Draw(spritebatch);
        }
        public void Update(GameTime gameTime)
        {


            norman.Update(gameTime);


            norman.Rotation = 0.0f;

            norman.Velocity = Vector2.Zero;

            HandleKeyboardInput(Keyboard.GetState());
            HandleGamepadInput(GamePad.GetState(PlayerIndex.One));

            norman.Velocity.Normalize();
            norman.Velocity *= playerSpeed;

            
            

        }
    }
}
