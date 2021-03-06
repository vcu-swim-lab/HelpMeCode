﻿using SolrNet.Attributes;
using System;

namespace Website.Utility.Solr
{
    public class CodeDoc
    {
        [SolrUniqueKey("id")]
        public string Id { get; set; }

        [SolrField("sha")]
        public string Sha { get; set; }

        [SolrField("author_name")]
        public string Author_Name { get; set; }

        [SolrField("committer_name")]
        public string Committer_Name { get; set; }

        [SolrField("author_date")]
        public DateTime Author_Date { get; set; }

        [SolrField("filename")]
        public string Filename { get; set; }

        [SolrField("previous_file_name")]
        public string Previous_File_Name { get; set; }

        [SolrField("blob_url")]
        public string Blob_Url { get; set; }

        [SolrField("raw_url")]
        public string Raw_Url { get; set; }

        [SolrField("content")]
        public string Content { get; set; }

        [SolrField("accesstoken")]
        public string Accesstoken { get; set; }

        [SolrField("patch")]
        public string Patch { get; set; }

        [SolrField("unindexed_patch")]
        public string Unindexed_Patch { get; set; }

        [SolrField("channel")]
        public string Channel { get; set; }

        [SolrField("repo")]
        public string Repo { get; set; }

        [SolrField("html_url")]
        public string Html_Url { get; set; }

        [SolrField("prog_language")]
        public string Prog_Language { get; set; }

        [SolrField("commit_message")]
        public string Message { get; set; }
    }
}