﻿using System.Reflection;

namespace MissingPieces.Metaprogramming
{
	/// <summary>
	/// Represents reflected property.
	/// </summary>
	public interface IProperty: IMember<PropertyInfo>
	{
		bool CanRead { get; }
		bool CanWrite { get; }
	}

	/// <summary>
	/// Represents static property.
	/// </summary>
	/// <typeparam name="P">Type of property value.</typeparam>
	public interface IProperty<P>: IProperty
	{
		/// <summary>
		/// Gets or sets property value.
		/// </summary>
		P Value{ get; set; }
	}

	/// <summary>
	/// Represents instance property.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="P"></typeparam>
	public interface IProperty<T, P>: IProperty
	{
		P this[T instance]{ get; set; }
	}
}
