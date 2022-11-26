﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;
using System;
using System.Collections.Generic;
using tmss.Authorization.Roles;

namespace tmss.Dto
{
    /*Mapped in CustomDtoMapper.cs*/
    public class UserDto : EntityDto<long>, IPassivable, IHasCreationTime
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public Guid? ProfilePictureId { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreationTime { get; set; }

        public int? TenantId { get; set; }

        public IEnumerable<RoleDto> Roles { get; set; }


        public UserDto()
        {
            Roles = new List<RoleDto>();
        }


        [AutoMapFrom(typeof(Role))]
        public class RoleDto
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string DisplayName { get; set; }
        }
    }
}