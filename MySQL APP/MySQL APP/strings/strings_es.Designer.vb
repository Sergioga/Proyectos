﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class strings_es
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("MySQL_APP.strings_es", GetType(strings_es).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Usuario o contraseña incorrectos.
        '''</summary>
        Friend Shared ReadOnly Property badStr() As String
            Get
                Return ResourceManager.GetString("badStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Continuar.
        '''</summary>
        Friend Shared ReadOnly Property contStr() As String
            Get
                Return ResourceManager.GetString("contStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ¡Todas las operaciones han finalizado correctamente!.
        '''</summary>
        Friend Shared ReadOnly Property creDBStr() As String
            Get
                Return ResourceManager.GetString("creDBStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Contraseña BBDD:.
        '''</summary>
        Friend Shared ReadOnly Property dbPassStr() As String
            Get
                Return ResourceManager.GetString("dbPassStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Servidor BBDD (nombre o IP):.
        '''</summary>
        Friend Shared ReadOnly Property dbServerStr() As String
            Get
                Return ResourceManager.GetString("dbServerStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Usuario BBDD:.
        '''</summary>
        Friend Shared ReadOnly Property dbUserStr() As String
            Get
                Return ResourceManager.GetString("dbUserStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No puedes dejar campos en blanco.
        '''</summary>
        Friend Shared ReadOnly Property emptyStr() As String
            Get
                Return ResourceManager.GetString("emptyStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Salir.
        '''</summary>
        Friend Shared ReadOnly Property exitStr() As String
            Get
                Return ResourceManager.GetString("exitStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Bloquear/Desbloquear ajustes.
        '''</summary>
        Friend Shared ReadOnly Property lockStr() As String
            Get
                Return ResourceManager.GetString("lockStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Contraseña:.
        '''</summary>
        Friend Shared ReadOnly Property passStr() As String
            Get
                Return ResourceManager.GetString("passStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Guardar cambios.
        '''</summary>
        Friend Shared ReadOnly Property saveBtnStr() As String
            Get
                Return ResourceManager.GetString("saveBtnStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ¡Esta apunto de borrar TODOS los datos de la base de datos e ha empezar de nuevo!. Para continuar debes introducir la contraseña de administrador de XXX..
        '''</summary>
        Friend Shared ReadOnly Property secStr() As String
            Get
                Return ResourceManager.GetString("secStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Ajustes.
        '''</summary>
        Friend Shared ReadOnly Property settingsStr() As String
            Get
                Return ResourceManager.GetString("settingsStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Iniciar la app.
        '''</summary>
        Friend Shared ReadOnly Property startStr() As String
            Get
                Return ResourceManager.GetString("startStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Usuario:.
        '''</summary>
        Friend Shared ReadOnly Property userStr() As String
            Get
                Return ResourceManager.GetString("userStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Se ha producido un error al realizar las operaciones, por favor comprueba los datos introducidos..
        '''</summary>
        Friend Shared ReadOnly Property wrgDBStr() As String
            Get
                Return ResourceManager.GetString("wrgDBStr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Contraseña incorrecta.
        '''</summary>
        Friend Shared ReadOnly Property wrgPass() As String
            Get
                Return ResourceManager.GetString("wrgPass", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
