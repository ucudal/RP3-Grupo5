namespace RoleplayGame
{
    public interface IHeroe
    {
        int VP { get; }

        public void GetVP(int vpGained);
    }
}
