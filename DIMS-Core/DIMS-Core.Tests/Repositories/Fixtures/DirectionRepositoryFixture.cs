using System;
using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;
using DIMS_Core.DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.X509.Qualified;

namespace DIMS_Core.Tests.Repositories.Fixtures
{
    internal class DirectionRepositoryFixture : AbstractRepositoryFixture<Direction>
    {
        public DirectionRepositoryFixture() : base(typeof(DirectionRepository))
        {
            
        }

        public int DirectionId { get; private set; }

        protected override void InitDatabase()
        {
            var entry = Context.Directions.Add(new Direction
                                               {
                                                   Name = "Test Direction",
                                                   Description = "Test Description"
                                               });
            DirectionId = entry.Entity.DirectionId;

            Context.SaveChanges();
            entry.State = EntityState.Detached;
        }

    }
}