using UnityEngine;
using System.Collections;

namespace GameData {

    [CreateAssetMenu(fileName = "unamedDice", menuName = "Data/Dice", order = 1)]
    public class Dice : ScriptableObject {

        public DiceColor color = DiceColor.RED;
        public byte faceCount = 1;
        
    }

    public enum DiceColor {
        RED,
        BLUE,
        GREEN
    }
}
