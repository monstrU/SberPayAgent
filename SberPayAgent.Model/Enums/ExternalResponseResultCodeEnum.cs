namespace SberPayAgent.Model.Enums
{
	/// <summary>
	/// Результат ответа веб-сервиса
	/// </summary>
	public enum ExternalResponseResultCodeEnum
	{

        /// <summary>
        /// Не задан
        /// </summary>
        
		None = 0,

		/// <summary>
		/// Успешный ответ
		/// </summary>
        Ok = 1,

        /// <summary>
        /// Ошибка передачи данных
        /// </summary>
        WebException = 2,

        /// <summary>
        /// Ошибка Http протокола
        /// </summary>
        HttpProtocolError = 3,

        /// <summary>
        /// Внутренняя ошибка
        /// </summary>
        InternalError = 4,
        
    }
}