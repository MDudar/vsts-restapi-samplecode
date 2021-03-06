﻿namespace VstsRestApiSamples.ViewModels.ProjectsAndTeams
{
    public class GetProjectResponse
    {
        public class Project : BaseViewModel
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string url { get; set; }
            public string state { get; set; }
            public _Links _links { get; set; }
        }

        public class _Links
        {
            public Self self { get; set; }
        }

        public class Self
        {
            public string href { get; set; }
        }

    }
}
