//-----------------------------------------------------------------------
// <copyright file=" Notice.cs" company="Vexel">
// * Copyright (C) 2026 Viken  All Rights Reserved
// * version : 1.0
// * author  : Viken
// * FileName: Notice.cs
// * history : Created by T4 2026-10-07 16:51:21
// </copyright>
//-----------------------------------------------------------------------
using SqlSugar;
using System;
using System.ComponentModel.DataAnnotations;

namespace Vexel.Domain.SystemOrganize
{
	/// <summary>
	/// Notice Entity Model
	/// </summary>
	[SugarTable("sys_notice")]
	public class NoticeEntity : IEntity<NoticeEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
	{
		/// <summary>
		/// Ö÷¼üId
		/// </summary>
		[SugarColumn(ColumnName = "F_Id", IsPrimaryKey = true, ColumnDescription = "Ö÷¼üId")]
		public string F_Id { get; set; }

		/// <summary>
		/// ±êÌâ
		/// </summary>
		[Required(ErrorMessage = "±êÌâ²»ÄÜÎª¿Õ")]
		[SugarColumn(IsNullable = true, ColumnName = "F_Title", ColumnDataType = "nvarchar(50)", ColumnDescription = "±êÌâ", UniqueGroupNameList = new string[] { "sys_notice" })]
		public string F_Title { get; set; }

		/// <summary>
		/// ÄÚÈÝ
		/// </summary>
		[Required(ErrorMessage = "ÄÚÈÝ²»ÄÜÎª¿Õ")]
		[SugarColumn(IsNullable = true, ColumnName = "F_Content", ColumnDataType = "longtext", ColumnDescription = "ÄÚÈÝ")]
		public string F_Content { get; set; }

		/// <summary>
		/// É¾³ý±ê¼Ç
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnDescription = "É¾³ý±ê¼Ç")]
		public Boolean? F_DeleteMark { get; set; }

		/// <summary>
		/// ÓÐÐ§±ê¼Ç
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnDescription = "ÓÐÐ§±ê¼Ç")]
		public Boolean? F_EnabledMark { get; set; }

		/// <summary>
		/// ±¸×¢
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnName = "F_Description", ColumnDataType = "longtext", ColumnDescription = "É¾³ýÈËId")]
		public string F_Description { get; set; }

		/// <summary>
		/// ´´½¨Ê±¼ä
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnDescription = "´´½¨Ê±¼ä")]
		public DateTime? F_CreatorTime { get; set; }

		/// <summary>
		/// ´´½¨ÈËId
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnName = "F_CreatorUserId", ColumnDataType = "nvarchar(50)", ColumnDescription = "´´½¨ÈËId")]
		public string F_CreatorUserId { get; set; }

		/// <summary>
		/// ´´½¨ÈËÐÕÃû
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnName = "F_CreatorUserName", ColumnDataType = "nvarchar(50)", ColumnDescription = "´´½¨ÈËÐÕÃû")]
		public string F_CreatorUserName { get; set; }

		/// <summary>
		/// ÐÞ¸ÄÊ±¼ä
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnDescription = "ÐÞ¸ÄÊ±¼ä")]
		public DateTime? F_LastModifyTime { get; set; }

		/// <summary>
		/// ÐÞ¸ÄÈËId
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnName = "F_LastModifyUserId", ColumnDataType = "nvarchar(50)", ColumnDescription = "ÐÞ¸ÄÈËId")]
		public string F_LastModifyUserId { get; set; }

		/// <summary>
		/// É¾³ýÊ±¼ä
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnDescription = "É¾³ýÊ±¼ä")]
		public DateTime? F_DeleteTime { get; set; }

		/// <summary>
		/// É¾³ýÈËId
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnName = "F_DeleteUserId", ColumnDataType = "nvarchar(50)", ColumnDescription = "É¾³ýÈËId")]
		public string F_DeleteUserId { get; set; }
	}
}