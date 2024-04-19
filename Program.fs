namespace BugRepro

open FSharp.Data.Sql

module Program =

    let [<Literal>] private ConnectionString = "Data Source=" + __SOURCE_DIRECTORY__ + "/BugRepro.db;foreign keys=true"
    let [<Literal>] private ResolutionPath = __SOURCE_DIRECTORY__ + @"/libs/win-x64"

    type sqLite = SqlDataProvider<
        Common.DatabaseProviderTypes.SQLITE,
        SQLiteLibrary = Common.SQLiteLibrary.MicrosoftDataSqlite,
        ConnectionString = ConnectionString, 
        CaseSensitivityChange = Common.CaseSensitivityChange.ORIGINAL,
        ResolutionPath = ResolutionPath,
        UseOptionTypes=Common.NullableColumnType.OPTION>

    [<EntryPoint>]
    let main _ = 
        0
    