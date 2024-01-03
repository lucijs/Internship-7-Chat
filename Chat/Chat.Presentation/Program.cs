using Chat.Presentation.Factories;
using Chat.Presentation.Extensions;

var homepageActions = HomepageFactory.CreateActions();
homepageActions.PrintActionsAndOpen();
