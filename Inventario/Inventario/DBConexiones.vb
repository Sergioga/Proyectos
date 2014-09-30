Module DBConexiones
    Public DBCon As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\InventoryDB.accdb;Persist Security Info=True;Jet OLEDB:Database Password=14Inventario0996;")
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public tr As OleDb.OleDbTransaction

    'tr = DBCon.BeginTransaction
    '    cmd.Connection = DBCon
    '    cmd.Transaction = tr
End Module
