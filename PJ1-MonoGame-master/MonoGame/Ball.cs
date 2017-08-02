using C3.XNA;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame
{
	public class Ball : GameObject
    {
        public Paddle paddle;
        public Wall topWall;
        public Wall leftWall;
        public Wall rightWall;
        public Bloco bloco;
        public bool atirar;

        public override void Load(ContentManager content)
        {
            animation.textures = new Texture2D[1];
            animation.textures[0] = content.Load<Texture2D>("fx-blow1");
            scale = 0.5f;

            position = new Vector2(250.0f, 100.0f);
            velocity = new Vector2(80.0f, 400.0f);

			collider.size = new Vector2( 75.0f, 75.0f );
        }

        public override void Update( GameTime gameTime )
		{
           
            if (BoxCollider.AreColliding(this, paddle))
            {
                velocity.Y *= -1.0f;
            }

            if( BoxCollider.AreColliding(this, topWall))
            {
                position = new Vector2 (paddle.position.X , paddle.position.Y);
            }

            if (BoxCollider.AreColliding(this, leftWall))
            {
                velocity.X *= -1.0f;
            }

            if (BoxCollider.AreColliding(this, rightWall))
            {
                velocity.X *= -1.0f;
            }

            if (atirar == false && Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                
            }

            if (atirar == true)
            {
                position = new Vector2(paddle.position.X, paddle.position.Y);
            }
           
        }
    }
}
