using System;
using System.Text;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ElectionProject.Migrations
{
    public partial class CreateUpdateCheckTriggerFunctionExample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.Sql(@"CREATE OR REPLACE function update_check()  RETURNS trigger   
                                            AS $$
                                            BEGIN 
	                                            IF new.id in(select citizen_id from check_updates) THEN
                                                UPDATE check_updates 
                                                SET citizen_id=new.id;
	                                            UPDATE check_updates
                                                SET updates_count = updates_count+1;
	                                            return new;
 	                                            END IF;
 	                                            IF new.id not in(select citizen_id from check_updates) THEN
	                                            insert into check_updates (citizen_id,updates_count) values (new.id,1);
	                                            return new;
	                                            end if;
                                            END;
                                            $$ LANGUAGE plpgsql ;
                                            
                                            CREATE TRIGGER citizen_update
                                            AFTER UPDATE OF district_id ON citizen
                                            FOR EACH ROW 
                                            execute procedure update_check();");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP FUNCTION update_check");
        }
    }
}
