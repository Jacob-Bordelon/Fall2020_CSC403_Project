using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
    /// <summary>
    /// This is the class for a BattleCharacter
    /// </summary>
    public class BattleCharacter : Character
    {
        /// <summary>
        /// This is the current health for a BattleCharacter
        /// </summary>
        public int Health { get; private set; }
       
        /// <summary>
        /// This is the Template for a BattleCharacter
        /// </summary>
        public Template CharacterTemplate { get; set; }
        /// <summary>
        /// sends the calculated damage to the frmBattle
        /// </summary>
        public event Action<int> AttackEvent;
        /// <summary>
        /// The Battle Character is the handler for combat mechanics
        /// </summary>
        /// <param name="initPos">initial position</param>
        /// <param name="collider">colision box</param>
        public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
            CharacterTemplate = new EnemyTemplate();
            SetHPValues();
        }

        /// <summary>
        /// Returns the ammount of damage done by an attack
        /// </summary>
        /// <param name="amount"></param>
        public void OnAttack(int amount)
        {
            int damage = 0;
            switch (CharacterTemplate.Level)
            {
                case 1:
                    damage = CharacterTemplate.FirstAttack();
                    break;
                case 2:
                    damage = CharacterTemplate.SeccondAttack();
                    break;
                case 3:
                    damage = CharacterTemplate.ThirdAttack();
                    break;
                default:
                    damage = 0;
                    break;
            }
            AttackEvent((int)(amount * damage));
        }
        /// <summary>
        /// Sets the level of a Character [1,3]
        /// </summary>
        /// <param name="level">the desired level of the character [1,3]</param>
        public void SetLevel(int level)
        {
            switch (level)
            {
                case 1:
                    CharacterTemplate.Level = 1;
                    CharacterTemplate.MaxHealth = CharacterTemplate.Level * CharacterTemplate.HealthPerLevel;
                    break;
                case 2:
                    CharacterTemplate.Level = 2;
                    CharacterTemplate.MaxHealth = CharacterTemplate.Level * CharacterTemplate.HealthPerLevel;
                    break;
                case 3:
                    CharacterTemplate.Level = 3;
                    CharacterTemplate.MaxHealth = CharacterTemplate.Level * CharacterTemplate.HealthPerLevel;
                    break;
                default:
                    CharacterTemplate.Level = 1;
                    CharacterTemplate.MaxHealth = CharacterTemplate.Level * CharacterTemplate.HealthPerLevel;
                    break;
            }
        }
        /// <summary>
        /// Adds or subtracts from the health pool bounded by MaxHealth and zero
        /// </summary>
        /// <param name="amount">the ammount to change the health</param>
        public void AlterHealth(int amount)
        {
            int hp = Health += amount;
            if (hp <= 0)
            {
                Health = 0;
            }
            else if (hp <= CharacterTemplate.MaxHealth)
            {
                Health = hp;
            }
            else if (hp > CharacterTemplate.MaxHealth)
            {
                Health = CharacterTemplate.MaxHealth;
            }
        }
        /// <summary>
        /// Changes the Characters Max Health by the input ammount
        /// </summary>
        /// <param name="amount">change the characters Max Health by this ammount</param>
        public void AlterMAXHealth(int amount)
        {
            CharacterTemplate.MaxHealth += amount;
        }
        /// <summary>
        ///  Changes the Characters Strength by the input ammount
        /// </summary>
        /// <param name="amount"></param>
        public void AlterStrength(int amount)
        {
            CharacterTemplate.Strength += amount;
        }
        /// <summary>
        /// Sets the value of health to the Max Health of the Character
        /// </summary>
        public void SetHPValues()
        {
            Health = CharacterTemplate.MaxHealth;
        }
    }
}