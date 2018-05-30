﻿using System.Collections.Generic;
using System.Web.Mvc;
using Southworks.Prode.Data.Models;

namespace Southworks.Prode.Web.Models
{
    public static class SelectLists
    {
        public static IEnumerable<SelectListItem> MatchStages = new List<SelectListItem>
        {
            new SelectListItem { Text = "Grupo A", Value = MatchStage.GroupA.ToString() },
            new SelectListItem { Text = "Grupo B", Value = MatchStage.GroupB.ToString() },
            new SelectListItem { Text = "Grupo C", Value = MatchStage.GroupC.ToString() },
            new SelectListItem { Text = "Grupo D", Value = MatchStage.GroupD.ToString() },
            new SelectListItem { Text = "Grupo E", Value = MatchStage.GroupE.ToString() },
            new SelectListItem { Text = "Grupo F", Value = MatchStage.GroupF.ToString() },
            new SelectListItem { Text = "Grupo G", Value = MatchStage.GroupG.ToString() },
            new SelectListItem { Text = "Octavos", Value = MatchStage.Round16.ToString() },
            new SelectListItem { Text = "Cuartos", Value = MatchStage.QuarterFinals.ToString() },
            new SelectListItem { Text = "Semis", Value = MatchStage.SemiFinals.ToString() },
            new SelectListItem { Text = "3er puesto", Value = MatchStage.ThirdPlace.ToString() },
            new SelectListItem { Text = "Final", Value = MatchStage.Final.ToString() }
        };
    }
}