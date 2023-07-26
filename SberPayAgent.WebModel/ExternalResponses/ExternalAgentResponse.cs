using System;
using System.Net;
using SberPayAgent.Interfaces.ExternalResponses;
using SberPayAgent.Model.Enums;

namespace SberPayAgent.WebModel.ExternalResponses
{
    /// <summary>
    /// Класс для описания ответа внешней системы
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ExternalAgentResponse<T> : IExternalAgentResponse<T> where T : class
    {
        /// <summary>
        /// Данные
        /// </summary>
        public T DataContainer { get; set; }

        /// <summary>
        /// Общий статус ошибки
        /// </summary>
        public ExternalResponseResultCodeEnum Status { get; set; }

        /// <summary>
        /// Общий статус web-запрос
        /// </summary>
        public Nullable<WebExceptionStatus>  WebExceptionStatus { get; set; }

        /// <summary>
        /// Статус HTTP-ошибки
        /// </summary>
        public HttpStatusCode HttpStatus { get; set; }

        /// <summary>
        /// Текст ошибки
        /// </summary>
        public string[] Messages { get; set; }

        public string RawRespose { get; set; }


        /// <summary>
        /// Класс для описания ответа внешней системы
        /// </summary>
        public ExternalAgentResponse()
        {
            Status = ExternalResponseResultCodeEnum.None;
            WebExceptionStatus = null;
            HttpStatus = HttpStatusCode.Unused;
            DataContainer = default;
            Messages = new string[0];
        }
    }
}