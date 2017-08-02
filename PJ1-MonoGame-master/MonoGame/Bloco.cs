using C3.XNA;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame
{   
     public class Bloco : GameObject
    {
        public Ball ball;
        public bool apagar;
        public bool colliderapagar;
        public Wall topWall;
        public override void Load(ContentManager content)
              

        {
            color = Color.Yellow;
            collider.size = new Vector2(100.0f, 50.0f);
            apagar = false;
            colliderapagar = false;
            
            velocity = new Vector2(0, 20.0f);

            animation.textures = new Texture2D[1];
            animation.textures[0] = content.Load<Texture2D>("alien-amarelo1");


        }

        public override void Update(GameTime gameTime)
        {
            float deltaT = ((float)gameTime.ElapsedGameTime.TotalMilliseconds * 0.001f);
            position += velocity * deltaT;
            

            if (apagar == false)
            {
                if (BoxCollider.AreColliding(this, ball))
                {
                    apagar = true;
                }
                if (BoxCollider.AreColliding(this, ball))
                {
                    ball.velocity.Y *= -1.0f;
                    colliderapagar = true;
                }
            }
        }
        
        public override void Draw(SpriteBatch spriteBatch)
        {
            Texture2D texture = animation.GetCurrentFrame();
            if (apagar==false )

                
            spriteBatch.Draw(texture, position, null, color,
                0.0f, Vector2.Zero, 5.0f, SpriteEffects.None, 0.0f);

            collider.Draw(spriteBatch, position);


        }
    }
}

