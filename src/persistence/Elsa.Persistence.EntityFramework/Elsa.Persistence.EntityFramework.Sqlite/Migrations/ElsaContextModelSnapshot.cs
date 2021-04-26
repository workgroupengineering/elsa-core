﻿// <auto-generated />
using System;
using Elsa.Persistence.EntityFramework.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Elsa.Persistence.EntityFramework.Sqlite.Migrations
{
    [DbContext(typeof(ElsaContext))]
    partial class ElsaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Elsa.Models.Bookmark", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ModelType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId")
                        .HasDatabaseName("IX_Bookmark_ActivityId");

                    b.HasIndex("ActivityType")
                        .HasDatabaseName("IX_Bookmark_ActivityType");

                    b.HasIndex("Hash")
                        .HasDatabaseName("IX_Bookmark_Hash");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("IX_Bookmark_TenantId");

                    b.HasIndex("WorkflowInstanceId")
                        .HasDatabaseName("IX_Bookmark_WorkflowInstanceId");

                    b.HasIndex("ActivityType", "TenantId", "Hash")
                        .HasDatabaseName("IX_Bookmark_ActivityType_TenantId_Hash");

                    b.ToTable("Bookmarks");
                });

            modelBuilder.Entity("Elsa.Models.WorkflowDefinition", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefinitionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("DeleteCompletedInstances")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLatest")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSingleton")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PersistenceBehavior")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tag")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IsLatest")
                        .HasDatabaseName("IX_WorkflowDefinition_IsLatest");

                    b.HasIndex("IsPublished")
                        .HasDatabaseName("IX_WorkflowDefinition_IsPublished");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_WorkflowDefinition_Name");

                    b.HasIndex("Tag")
                        .HasDatabaseName("IX_WorkflowDefinition_Tag");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("IX_WorkflowDefinition_TenantId");

                    b.HasIndex("Version")
                        .HasDatabaseName("IX_WorkflowDefinition_Version");

                    b.HasIndex("DefinitionId", "Version")
                        .HasDatabaseName("IX_WorkflowDefinition_DefinitionId_VersionId");

                    b.ToTable("WorkflowDefinitions");
                });

            modelBuilder.Entity("Elsa.Models.WorkflowExecutionLogRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("EventName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityId");

                    b.HasIndex("ActivityType")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityType");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_TenantId");

                    b.HasIndex("Timestamp")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_Timestamp");

                    b.HasIndex("WorkflowInstanceId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowInstanceId");

                    b.ToTable("WorkflowExecutionLogRecords");
                });

            modelBuilder.Entity("Elsa.Models.WorkflowInstance", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CancelledAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContextId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContextType")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefinitionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FaultedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FinishedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastExecutedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WorkflowStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ContextId")
                        .HasDatabaseName("IX_WorkflowInstance_ContextId");

                    b.HasIndex("ContextType")
                        .HasDatabaseName("IX_WorkflowInstance_ContextType");

                    b.HasIndex("CorrelationId")
                        .HasDatabaseName("IX_WorkflowInstance_CorrelationId");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("IX_WorkflowInstance_CreatedAt");

                    b.HasIndex("DefinitionId")
                        .HasDatabaseName("IX_WorkflowInstance_DefinitionId");

                    b.HasIndex("FaultedAt")
                        .HasDatabaseName("IX_WorkflowInstance_FaultedAt");

                    b.HasIndex("FinishedAt")
                        .HasDatabaseName("IX_WorkflowInstance_FinishedAt");

                    b.HasIndex("LastExecutedAt")
                        .HasDatabaseName("IX_WorkflowInstance_LastExecutedAt");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_WorkflowInstance_Name");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("IX_WorkflowInstance_TenantId");

                    b.HasIndex("WorkflowStatus")
                        .HasDatabaseName("IX_WorkflowInstance_WorkflowStatus");

                    b.HasIndex("WorkflowStatus", "DefinitionId", "Version")
                        .HasDatabaseName("IX_WorkflowInstance_WorkflowStatus_DefinitionId_Version");

                    b.ToTable("WorkflowInstances");
                });
#pragma warning restore 612, 618
        }
    }
}
