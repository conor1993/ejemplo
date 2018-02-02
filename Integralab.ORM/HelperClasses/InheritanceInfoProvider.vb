'///////////////////////////////////////////////////////////////
' This is generated code. If you modify this code, be aware
' of the fact that when you re-generate the code, your changes
' are lost. If you want to keep your changes, make this file read-only
' when you have finished your changes, however it is recommended that
' you inherit from this class to extend the functionality of this generated
' class or you modify / extend the templates used to generate this code.
'//////////////////////////////////////////////////////////////
' Code is generated using LLBLGen Pro version: 2.0.0.0
' Code is generated on: viernes, 2 de febrero de 2018 11:54:43
' Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
' Templates vendor: Solutions Design.
' Templates version: 
'///////////////////////////////////////////////////////////////
Imports System
Imports Integralab.ORM.FactoryClasses
Imports Integralab.ORM.RelationClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses


' __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
' __LLBLGENPRO_USER_CODE_REGION_END
Namespace Integralab.ORM.HelperClasses
	''' <summary>
	''' Singleton implementation of the inheritanceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	''' </summary>
	''' <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the InheritanceInfoProviderBase class is threadsafe.</remarks>
	Public NotInheritable Class InheritanceInfoProviderSingleton
#Region "Class Member Declarations"
		Private Shared ReadOnly _providerInstance As IInheritanceInfoProvider = New InheritanceInfoProviderCore()
#End Region
		
		''' <summary>private ctor to prevent instances of this class.</summary>
		Private Sub New()
		End Sub

		''' <summary>Initializes the <see cref="InheritanceInfoProvider"/> class.</summary>
		Shared Sub New()
		End Sub

		''' <summary>Gets the singleton instance of the InheritanceInfoProviderCore</summary>
		''' <returns>Instance of the InheritanceInfoProvider.</returns>
		Public Shared Function GetInstance() As IInheritanceInfoProvider
			Return _providerInstance
		End Function
		
#Region "Custom InheritanceInfoProviderSingleton code"
		
		' __LLBLGENPRO_USER_CODE_REGION_START CustomInheritanceInfoProviderSingletonCode
		' __LLBLGENPRO_USER_CODE_REGION_END
		
#End Region
	End Class


	''' <summary>Actual implementation of the InheritanceInfoProvider. Used by singleton wrapper.</summary>
	Friend Class InheritanceInfoProviderCore 
		Inherits InheritanceInfoProviderBase
		
		''' <summary>Initializes a new instance of the <see cref="InheritanceInfoProviderCore"/> class.</summary>
		Friend Sub New()
			Init()
		End Sub

		''' <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		Private Sub Init()

			MyBase.BuildHierarchyInfoStore()
		End Sub

		''' <summary>Gets the entity fields for the entity passed in. Only the fields defined in the entity are returned</summary>
		''' <param name="entityName">Name of the entity to grab the fields for</param>
		''' <returns>array of IEntityFieldCore fields</returns>
		Public Overrides Function GetEntityFields(entityName As String) As IEntityFieldCore()
			Return EntityFieldsFactory.CreateFields(entityName)
		End Function
	End Class
End Namespace




