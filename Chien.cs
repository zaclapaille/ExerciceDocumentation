using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDocumentation
{
    /// <summary>
    /// cette classe sert a créer des chiens
    /// </summary>
    public class Chien
    {
        private int Age { get; set; }
        private string Name { get; }
        private string Color { get; }
        private string Race { get; }
        private bool Sex { get; }
        /// <summary>
        /// un chien as un âge, un nom, une couleur, une race, et un sexe
        /// </summary>
        /// <param name="age"> l'age est un nom entier</param>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="race"></param>
        /// <param name="sex"> 0 pour un male et 1 pour une femelle</param>
        public Chien(int age, string name, string color, string race, bool sex)
        {
            Age = age;
            Name = name;
            Color = color;
            Race = race;
            Sex = sex;
        }
        /// <summary>
        /// retourne le nom du chien
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return Name;
        }
        /// <summary>
        /// permet de faire viellir un chien de X années
        /// </summary>
        /// <param name="age"> le nombre d'anner pour viellir le chien</param>
        public void GrowOlder(int age)
        {
            Age += age;
        }

    }
}
