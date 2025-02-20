﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosApp.Infra.Messages.Settings
{
    /// <summary>
    /// Classe para mapear / configurar as informações de conexão
    /// com o servidor da mensageria e com a fila que iremos acessar
    /// </summary>
    public class RabbitMQSettings
    {
        /// <summary>
        /// Caminho para conexão com o servidor da mensageria
        /// </summary>
        public static string Url => "amqps://xcxxhbmq:QpWwHlmUp5mrl4ELOBLxbcUQBK2tDmKH@gull.rmq.cloudamqp.com/xcxxhbmq";                                     
        /// <summary>
        /// Nome da fila que iremos acessar no servidor
        /// </summary>
        public static string Queue => "mensagens_email";
    }
}



