using System;
using System.Net;
using SberPayAgent.Model.Enums;

namespace SberPayAgent.Interfaces.ExternalResponses
{
    /// <summary>
    /// Базовый интерфейс для ответа метода агента внешней системы
    /// </summary>
    public interface IExternalAgentResponse<T> : IExternalAgentResponse where T : class
    {
        /// <summary>
        /// Объект с ответом
        /// </summary>
        T DataContainer { get; set; }
    }

    /// <summary>
    /// Базовый интерфейс для ответа метода агента внешней системы
    /// </summary>
    public interface IExternalAgentResponse
    {

        /// <summary>
        /// Тип ошибки при обращении к методу агента
        /// Универсальный вычисленный ответ
        /// </summary>
        /// 
        ExternalResponseResultCodeEnum Status { get; set; }

        /// <summary>
        /// Статус web-запроса
        /// </summary>
        Nullable<WebExceptionStatus>  WebExceptionStatus { get; set; }

        /// <summary>
        /// Статус HTTP-ответа при вызове метода агента 
        /// </summary>
        HttpStatusCode HttpStatus { get; set; }

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        string[] Messages { get; set; }

        /// <summary>
        /// сырой ответ от хоста
        /// </summary>
        string RawRespose { get; set; }
    }
}