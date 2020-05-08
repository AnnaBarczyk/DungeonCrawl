using System;

namespace Codecool.DungeonCrawl.Logic.Actors
{
    /// <summary>
    /// The game player
    /// </summary>
    public class Player : Actor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="cell">The starting cell</param>

        public Player(Cell cell)
            : base(cell)
        {
            Health = 100;
        }

        /// <inheritdoc/>
        public override string Tilename => "player";

        /// <summary>
        /// Moves player by the given amount
        /// </summary>
        /// <param name="dx">X amoount</param>
        /// <param name="dy">Y amount</param>
        public override void Move(int dx, int dy)
        {
            Cell nextCell = Cell.GetNeighbor(dx, dy);
            if (nextCell.Tilename == "Floor")
            {
                if (nextCell.Actor == null)
                {
                    Cell.Actor = null;
                    nextCell.Actor = this;
                    Cell = nextCell;
                }
            }
        }
    }
}
