﻿
﻿using System;

namespace Enemies
{
    /// <summary>
    /// Empty Zombie Class.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// public field health.
        /// </summary>
        public int health;
        private string name = "(No name)";

        /// <summary> gets or sets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// <param name="value"> The value of health.</param>
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>
        /// Return the value of health of the zombie
        /// </summary>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>
        /// Return the Zombie Object's attributes
        /// </summary>
        public override string ToString()
        {
            return $"Zombie Name: {this.name} / Total Health: {this.health}";
        }
    }
}
