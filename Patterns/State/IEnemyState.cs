namespace State
{
    interface IEnemyState
    {
        public Enemy Enemy { get; set; }
        void Action();
    }
}
