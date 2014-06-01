﻿using System;
using System.Collections.Generic;
using System.Linq;
using Blog.Domain.Infrastructure.Persistence;
using Blog.Domain.Infrastructure.Persistence.Entities;
using Blog.Domain.Paging;

namespace Blog.Domain.Service
{
    public class EntryService
    {
        public PagedList<Entry> PaginatedList(int pageNumber, int pageSize)
        {
            using (var repository = new Repository<Entry>())
            {
                var entries =
                    repository
                        .All()
                        .OrderByDescending(e => e.PublishedAt);

                return entries.ToPagedList(pageNumber, pageSize);
            }
        }

        public int EntriesCount()
        {
            using (var repository = new Repository<Entry>())
            {
                return repository.All().Count();
            }
        }

        public List<Entry> List()
        {
            using (var repository = new Repository<Entry>())
            {
                return
                    repository
                        .All()
                        .OrderByDescending(e => e.PublishedAt).ToList();
            }
        }

        public Entry Single(string slug)
        {
            using (var repository = new Repository<Entry>())
            {
                var entry =
                    repository
                        .All()
                        .FirstOrDefault(e => e.Slug == slug);

                return entry;
            }
        }

        public bool Add(Entry entry)
        {
            try
            {
                using (var repository = new Repository<Entry>())
                {
                    repository.Add(entry);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        public void Delete(string slug)
        {
            using (var repository = new Repository<Entry>())
            {
                var entry = repository.Find(slug);
                repository.Delete(entry);
            }
        }

        public void Update(Entry entry)
        {
            using (var repository = new Repository<Entry>())
            {
                repository.Update(entry, entry.Slug);
            }
        }
    }
}