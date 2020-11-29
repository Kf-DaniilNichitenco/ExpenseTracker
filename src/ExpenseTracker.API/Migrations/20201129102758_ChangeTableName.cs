﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseTracker.API.Migrations
{
    public partial class ChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_Purses_PurseId",
                table: "Expense");

            migrationBuilder.DropForeignKey(
                name: "FK_Expense_Topics_TopicId",
                table: "Expense");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expense",
                table: "Expense");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "UserInfos");

            migrationBuilder.RenameTable(
                name: "Expense",
                newName: "Expenses");

            migrationBuilder.RenameIndex(
                name: "IX_Expense_TopicId",
                table: "Expenses",
                newName: "IX_Expenses_TopicId");

            migrationBuilder.RenameIndex(
                name: "IX_Expense_PurseId",
                table: "Expenses",
                newName: "IX_Expenses_PurseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInfos",
                table: "UserInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Purses_PurseId",
                table: "Expenses",
                column: "PurseId",
                principalTable: "Purses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Topics_TopicId",
                table: "Expenses",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Purses_PurseId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Topics_TopicId",
                table: "Expenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInfos",
                table: "UserInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses");

            migrationBuilder.RenameTable(
                name: "UserInfos",
                newName: "People");

            migrationBuilder.RenameTable(
                name: "Expenses",
                newName: "Expense");

            migrationBuilder.RenameIndex(
                name: "IX_Expenses_TopicId",
                table: "Expense",
                newName: "IX_Expense_TopicId");

            migrationBuilder.RenameIndex(
                name: "IX_Expenses_PurseId",
                table: "Expense",
                newName: "IX_Expense_PurseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expense",
                table: "Expense",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_Purses_PurseId",
                table: "Expense",
                column: "PurseId",
                principalTable: "Purses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_Topics_TopicId",
                table: "Expense",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
