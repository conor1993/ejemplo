' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version 2.0.0.0
' // Code is generated on lunes, 23 de abril de 2018 15:21:54
' // Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
' // Templates vendor: Solutions Design.
' // Templates version: 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
Imports System

Imports SD.LLBLGen.Pro.ORMSupportClasses

Namespace Integralab.ORM.HelperClasses
	''' <summary>
	''' Class for the returning of a default value when a type is given. These
	''' Default values are used for EntityFields which have a NULL value in the database.
	''' In Business Logic it's impractical to work with NULL values. If you want different values
	''' as default values for NULL values for a given type, alter the DefaultValue method below.
	''' If you want to keep your values when regenerating the code, make this file read-only, or bind a different
	''' template to the template ID: SD_TypeDefaultValueIncludeTemplate, or alter the template file currently 
	''' bound to that template ID.
	''' </summary>
	Public Class TypeDefaultValue 
		Implements ITypeDefaultValue
	
		''' <summary>
		''' Ctor
		''' </summary>
		Public Sub New()
		End Sub


		''' <summary>
		''' Returns a default value for the type specified
		''' </summary>
		''' <param name="defaultValueType">The type which default value should be returned.</param>
		''' <returns>The default value for the type specified.</returns>
		Public Function DefaultValue(defaultValueType As System.Type) As Object Implements ITypeDefaultValue.DefaultValue
			Return TypeDefaultValue.GetDefaultValue(defaultValueType)
		End Function


		''' <summary>
		''' Returns a default value for the type specified
		''' </summary>
		''' <param name="defaultValueType">The type which default value should be returned.</param>
		''' <returns>The default value for the type specified.</returns>
		Public Shared Function GetDefaultValue(defaultValueType As System.Type) As Object
			Dim valueToReturn As Object = Nothing

			Select Case defaultValueType.UnderlyingSystemType.FullName
				Case "System.String"
					valueToReturn=""
				Case "System.Int32"
					valueToReturn = CInt(0)
				Case "System.Int16"
					valueToReturn = CShort(0)
				Case "System.Byte"
					valueToReturn = CByte(0)
				Case "System.Int64"
					valueToReturn = CLng(0)
				Case "System.DateTime"
					valueToReturn = DateTime.MinValue
				Case "System.Decimal"
					valueToReturn = 0.0D
				Case "System.Double"
					valueToReturn = 0.0R
				Case "System.Single"
					valueToReturn = 0.0F
				Case "System.Boolean"
					valueToReturn = False
				Case "System.Byte[]"
					valueToReturn = New Byte(-1) {}
				Case "System.Guid"
					valueToReturn = Guid.Empty
				Case Else
					' do nothing, return Nothing.
			End Select

			Return valueToReturn


		End Function

#Region "Included Code"

#End Region
	End Class
End Namespace

