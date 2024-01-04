﻿using Chat.Data.Entities.Models;
using Chat.Presentation.Extensions;

namespace Chat.Presentation.Abstractions
{
    public class BaseMenuAction : IMenuAction
    {
        public int MenuIndex { get; set; }
        public User User { get; set; }

        public string Name { get; set; } = "NoName action";
        public IList<IAction> Actions { get; set; }

        public BaseMenuAction(IList<IAction> actions)
        {
            actions.SetActionIndexes();
            Actions = actions;
        }

        public virtual void Open()
        {
            Actions.PrintActionsAndOpen();
        }
    }
}
