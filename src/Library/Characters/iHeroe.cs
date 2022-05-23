namespace RoleplayGame
{
    public interface IHeroe
    {
        public int VP { get; }
        public int AttackValue{get;}
         public int DefenseValue{get;}
         public void ReceiveAttack(int power);
    }
}