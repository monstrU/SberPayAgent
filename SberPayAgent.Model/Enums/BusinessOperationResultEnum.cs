namespace SberPayAgent.Model.Enums
{
    /// <summary>
    /// возможные результаты бизнес-операции 
    /// </summary>
    public enum BusinessOperationResultEnum
    {
        /// <summary>
        /// не задан
        /// </summary>
        None = 0,

        /// <summary>
        /// операция прошла успешно
        /// </summary>
        Success = 1,

        /// <summary>
        /// ошибка при выполнении операции 
        /// </summary>
        ResultError = 2,
    }
}