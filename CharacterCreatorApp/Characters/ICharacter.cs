namespace CharacterCreatorApp.Characters
{
    public interface ICharacter // abstract factory method
    {
        public string Description { get; set; }
        public string Name { get; set; }
        int Health { get; set; }
        bool IsAlive { get; }
        int Armour { get; set; }
        void Attack(ICharacter target);
        void TakeDamage(int damage);


    }
}
