using C3.XNA;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame
{
    public class Paddle : GameObject
    {
        public Wall topWall;
        public Wall leftWall;
        public Wall rightWall;
        public Ball ball;
        public override void Load(ContentManager content)
        {
            color = Color.Blue;
            position = new Vector2( 250, 400 );
            collider.size = new Vector2(80.0f, 80.0f);

            animation.textures = new Texture2D[1];
            animation.textures[0] = content.Load<Texture2D>("alien-azul1");
        }

        public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                position.X += 4.0f;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                position.X -= 4.0f;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                

            }

        }   



        public override void Draw(SpriteBatch spriteBatch)
        {
            Texture2D texture = animation.GetCurrentFrame();
            spriteBatch.Draw(texture, position, null, color,
                0.0f, Vector2.Zero, 5.0f, SpriteEffects.None, 0.0f);

            collider.Draw(spriteBatch, position);
        }
    }
}
