namespace State
{
    class Enemy
    {
        public IEnemyState CurrentState { get; set; }
        public Enemy()
        {
            CurrentState = new IdleState() {Enemy = this};
        }
        public int HP { get; set; }
        public void Action()
        {
            CurrentState.Action();
        }
    }
}
