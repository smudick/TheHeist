using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class Team
    {
        public List<TeamMember> TeamMembers { get; set; } = new List<TeamMember>();

        public void AddTeamMembers(TeamMember teamMember)
        {
            TeamMembers.Add(teamMember);
        }
    }
}
