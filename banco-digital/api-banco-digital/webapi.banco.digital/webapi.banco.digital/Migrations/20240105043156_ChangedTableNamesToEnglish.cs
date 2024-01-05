using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.banco.digital.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTableNamesToEnglish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transferencias_Usuarios_IdRecipientUser",
                table: "Transferencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Transferencias_Usuarios_IdSenderUser",
                table: "Transferencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Contas_IdAccount",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_TiposUsuario_IdUserType",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transferencias",
                table: "Transferencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposUsuario",
                table: "TiposUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contas",
                table: "Contas");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Transferencias",
                newName: "Transfers");

            migrationBuilder.RenameTable(
                name: "TiposUsuario",
                newName: "UserTypes");

            migrationBuilder.RenameTable(
                name: "Contas",
                newName: "Accounts");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_IdUserType",
                table: "Users",
                newName: "IX_Users_IdUserType");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_IdAccount",
                table: "Users",
                newName: "IX_Users_IdAccount");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_Email",
                table: "Users",
                newName: "IX_Users_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_CpfOrCnpj",
                table: "Users",
                newName: "IX_Users_CpfOrCnpj");

            migrationBuilder.RenameIndex(
                name: "IX_Transferencias_IdSenderUser",
                table: "Transfers",
                newName: "IX_Transfers_IdSenderUser");

            migrationBuilder.RenameIndex(
                name: "IX_Transferencias_IdRecipientUser",
                table: "Transfers",
                newName: "IX_Transfers_IdRecipientUser");

            migrationBuilder.RenameIndex(
                name: "IX_TiposUsuario_Name",
                table: "UserTypes",
                newName: "IX_UserTypes_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Contas_Number",
                table: "Accounts",
                newName: "IX_Accounts_Number");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transfers",
                table: "Transfers",
                column: "IdTransfer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTypes",
                table: "UserTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "IdAccount");

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Users_IdRecipientUser",
                table: "Transfers",
                column: "IdRecipientUser",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Users_IdSenderUser",
                table: "Transfers",
                column: "IdSenderUser",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Accounts_IdAccount",
                table: "Users",
                column: "IdAccount",
                principalTable: "Accounts",
                principalColumn: "IdAccount",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTypes_IdUserType",
                table: "Users",
                column: "IdUserType",
                principalTable: "UserTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Users_IdRecipientUser",
                table: "Transfers");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Users_IdSenderUser",
                table: "Transfers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Accounts_IdAccount",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTypes_IdUserType",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTypes",
                table: "UserTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transfers",
                table: "Transfers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.RenameTable(
                name: "UserTypes",
                newName: "TiposUsuario");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Transfers",
                newName: "Transferencias");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "Contas");

            migrationBuilder.RenameIndex(
                name: "IX_UserTypes_Name",
                table: "TiposUsuario",
                newName: "IX_TiposUsuario_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Users_IdUserType",
                table: "Usuarios",
                newName: "IX_Usuarios_IdUserType");

            migrationBuilder.RenameIndex(
                name: "IX_Users_IdAccount",
                table: "Usuarios",
                newName: "IX_Usuarios_IdAccount");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email",
                table: "Usuarios",
                newName: "IX_Usuarios_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CpfOrCnpj",
                table: "Usuarios",
                newName: "IX_Usuarios_CpfOrCnpj");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_IdSenderUser",
                table: "Transferencias",
                newName: "IX_Transferencias_IdSenderUser");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_IdRecipientUser",
                table: "Transferencias",
                newName: "IX_Transferencias_IdRecipientUser");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_Number",
                table: "Contas",
                newName: "IX_Contas_Number");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposUsuario",
                table: "TiposUsuario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transferencias",
                table: "Transferencias",
                column: "IdTransfer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contas",
                table: "Contas",
                column: "IdAccount");

            migrationBuilder.AddForeignKey(
                name: "FK_Transferencias_Usuarios_IdRecipientUser",
                table: "Transferencias",
                column: "IdRecipientUser",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transferencias_Usuarios_IdSenderUser",
                table: "Transferencias",
                column: "IdSenderUser",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Contas_IdAccount",
                table: "Usuarios",
                column: "IdAccount",
                principalTable: "Contas",
                principalColumn: "IdAccount",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_TiposUsuario_IdUserType",
                table: "Usuarios",
                column: "IdUserType",
                principalTable: "TiposUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
