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
    public class BattleCharacter : Character {
        /// <summary>
        /// This is the current health for a BattleCharacter
        /// </summary>
        public int Health { get; private set; }
        /// <summary>
        /// This is the Maximum health for a BattleCharacter
        /// </summary>
        public int MaxHealth { get; private set; }
        /// <summary>
        /// This is the Template for a BattleCharacter
        /// </summary>
        public Template CharacterTemplate { get; set; }

        /// <summary>
        /// sends the calculated damage to the frmBattle
        /// </summary>
        public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      CharacterTemplate = new EnemyTemplate();
      MaxHealth = CharacterTemplate.MaxHealth;
      Health = MaxHealth;
    }

    public void OnAttack(int amount) {
            int damage = 0;
            if (CharacterTemplate.Level == 1) { damage = CharacterTemplate.firstAttack(); }
            else if (CharacterTemplate.Level == 2) { damage = CharacterTemplate.seccondAttack(); }
            else if (CharacterTemplate.Level == 3) { damage = CharacterTemplate.thirdAttack(); }
            AttackEvent((int)(amount * damage));
    }
    public void SetTemplate(int type)
        {
            CharacterTemplate = GetTemplate(type);
        }
    internal Template GetTemplate (int type)
        {
            if(type == 0)
            {
                return new Fighter();
            }
            else if (type == 1)
            {
                return new Wizard();
            }
            else if (type == 2)
            {
                return new Rogue();
            }
            else if (type == 3)
            {
                return new Cheetocat();
            }
            else
            {
                return new Fighter();
            }
        }

    public void SetLevel(int level)
        {
            CharacterTemplate.Level = level;
        }
    //Adds or subtracts from the health pool bounded by MaxHealth and zero
    public void AlterHealth(int amount) {
            int hp = Health += amount;
            if (hp <= 0)
            {
                Health = 0;
            }
            else if (hp <= MaxHealth)
            {
                Health = hp;
            }
            else if (hp > MaxHealth)
            {
                Health = MaxHealth;
            }
    }
  }
}
