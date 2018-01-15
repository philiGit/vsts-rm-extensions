﻿using System.Collections.Generic;

namespace VstsServerTaskHelper.Core.Request
{
    public class TaskMessage
    {
        private readonly string taskMessageBody;
        private readonly TaskProperties taskProperties;

        public TaskMessage(string taskMessageBody, IDictionary<string, string> taskProperties)
            : this(taskMessageBody, new TaskProperties(taskProperties))
        {
        }

        public TaskMessage(string taskMessageBody, TaskProperties taskProperties)
        {
            this.taskMessageBody = taskMessageBody;
            this.taskProperties = taskProperties;
        }

        public string GetTaskMessageBody()
        {
            return taskMessageBody;
        }

        public TaskProperties GetTaskProperties()
        {
            return taskProperties;
        }
    }
}