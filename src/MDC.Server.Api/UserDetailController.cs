﻿using MDC.Server.Api.Commons;
using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.UserDetails;
using MDC.Server.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MDC.Server.Api
{
    [ApiController]
    [Route("user-details")]
    public class UserDetailController : ControllerBase
    {
        private readonly IUserDetailService _userDetailService;
        public UserDetailController(IUserDetailService userDetailService)
        {
            this._userDetailService = userDetailService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] UserDetailForCreationDto dto)
            => Ok(await this._userDetailService.CreateAsync(dto));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(await _userDetailService.RetrieveAllAsync(@params));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute(Name = "id")] long id)
            => Ok(await this._userDetailService.RetrieveByIdAsync(id));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync([FromRoute(Name = "id")] long id, [FromBody] UserDetailForUpdateDto dto)
            => Ok(await this._userDetailService.ModifyAsync(id, dto));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] long id)
            => Ok(await this._userDetailService.RemoveAsync(id));
    }
}
