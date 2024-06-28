using CharacterCreatorApp.Observers;
using CharacterCreatorApp.Strategies;

namespace CharacterCreatorApp.Characters
{
    public abstract class Enemy : ICharacter //abstract factory - abstract class for all enemies
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public IAttackStrategy _attackStrategy;
        public List<IAttackStrategy> _availableStrategies; // list of the enemy's attacks
        public bool IsAlive => Health > 0;
        public int Armour { get; set; }



        public void Attack(ICharacter target) // attacks the player
        {
            if (_attackStrategy == null)
            {
                Console.WriteLine("No attack strategy set!");
                return;
            }

            if (IsAlive)
            {
                _attackStrategy.Attack(this, target);
            }
        }

        public void TakeDamage(int damage) // takes damage from player
        {
            Health -= damage;
            Console.WriteLine($"{Name} takes {damage} damage.");
        }

        public void ChooseAttackStrategy()
        {
            _attackStrategy = _availableStrategies[new Random().Next(_availableStrategies.Count)]; // enemy chooses an attack at random
        }

        //----------- OBSERVER ------------------------------------------

        private List<IObserver> _observers = new List<IObserver>(); // list of observers (in this case only the player)

        public void Attach(IObserver observer) // adds an observer
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer) //removes an observer
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this); // updates all observers
            }
        }
        //--------------------------------------------------------------------
    }
}
