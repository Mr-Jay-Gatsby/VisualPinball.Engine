using System;
using System.IO;
using System.Net;
using System.Reflection;
using VisualPinball.Engine.Math;
using VisualPinball.Engine.VPT;
using Xunit;
using Xunit.Abstractions;

namespace VisualPinball.Engine.Test.VPT
{
	public class TextureDataTests
	{
		private readonly Engine.VPT.Table.Table _table;

		public TextureDataTests()
		{
			_table = Engine.VPT.Table.Table.Load(@"..\..\Fixtures\TextureData.vpx");
		}

		[Fact]
		public void ShouldLoadCorrectArgb()
		{
			var texture = _table.Textures["test_pattern_argb"];
			var blob = texture.FileContent;
			var image = File.ReadAllBytes(@"..\..\Fixtures\test_pattern_argb.bmp");
			Assert.Equal(1024, texture.Data.Width);
			Assert.Equal(768, texture.Data.Height);
			Assert.Equal("test_pattern_argb", texture.Data.InternalName);
			Assert.Equal(1.0f, texture.Data.AlphaTestValue);
			Assert.StartsWith(@"C:\", texture.Data.Path);
			Assert.Equal(image, blob);
		}

		[Fact]
		public void ShouldLoadCorrectBmp()
		{
			var texture = _table.Textures["test_pattern_bmp"];
			var blob = texture.FileContent;
			var image = File.ReadAllBytes(@"..\..\Fixtures\test_pattern.bmp");
			Assert.Equal(1024, texture.Data.Width);
			Assert.Equal(768, texture.Data.Height);
			Assert.Equal("test_pattern_bmp", texture.Data.InternalName);
			Assert.Equal(1.0f, texture.Data.AlphaTestValue);
			Assert.StartsWith(@"C:\", texture.Data.Path);
			Assert.Equal(image, blob);
		}

		[Fact]
		public void ShouldLoadCorrectExr()
		{
			var texture = _table.Textures["test_pattern_exr"];
			var blob = texture.FileContent;
			var image = File.ReadAllBytes(@"..\..\Fixtures\comp_piz.exr");
			Assert.Equal(587, texture.Data.Width);
			Assert.Equal(675, texture.Data.Height);
			Assert.Equal("test_pattern_exr", texture.Data.InternalName);
			Assert.Equal(1.0f, texture.Data.AlphaTestValue);
			Assert.StartsWith(@"C:\", texture.Data.Path);
			Assert.Equal(image, blob);
		}

		[Fact]
		public void ShouldLoadCorrectHdr()
		{
			var texture = _table.Textures["test_pattern_hdr"];
			var blob = texture.FileContent;
			var image = File.ReadAllBytes(@"..\..\Fixtures\test_pattern_hdr.hdr");
			Assert.Equal(1024, texture.Data.Width);
			Assert.Equal(512, texture.Data.Height);
			Assert.Equal("test_pattern_hdr", texture.Data.InternalName);
			Assert.Equal(1.0f, texture.Data.AlphaTestValue);
			Assert.StartsWith(@"C:\", texture.Data.Path);
			Assert.Equal(image, blob);
		}

		[Fact]
		public void ShouldLoadCorrectJpg()
		{
			var texture = _table.Textures["test_pattern_jpg"];
			var blob = texture.FileContent;
			var image = File.ReadAllBytes(@"..\..\Fixtures\test_pattern.jpg");
			Assert.Equal(1024, texture.Data.Width);
			Assert.Equal(768, texture.Data.Height);
			Assert.Equal("test_pattern_jpg", texture.Data.InternalName);
			Assert.Equal(1.0f, texture.Data.AlphaTestValue);
			Assert.StartsWith(@"C:\", texture.Data.Path);
			Assert.Equal(image, blob);
		}

		[Fact]
		public void ShouldLoadCorrectPng()
		{
			var texture = _table.Textures["test_pattern_png"];
			var blob = texture.FileContent;
			var image = File.ReadAllBytes(@"..\..\Fixtures\test_pattern.png");
			Assert.Equal(1024, texture.Data.Width);
			Assert.Equal(768, texture.Data.Height);
			Assert.Equal("test_pattern_png", texture.Data.InternalName);
			Assert.Equal(1.0f, texture.Data.AlphaTestValue);
			Assert.StartsWith(@"C:\", texture.Data.Path);
			Assert.Equal(image, blob);
		}

		[Fact]
		public void ShouldLoadCorrectTransparentPng()
		{
			var texture = _table.Textures["test_pattern_transparent"];
			var blob = texture.FileContent;
			var image = File.ReadAllBytes(@"..\..\Fixtures\test_pattern_transparent.png");
			//File.WriteAllBytes(@"..\..\Fixtures\debug.bmp", textureData);
			Assert.Equal(1024, texture.Data.Width);
			Assert.Equal(768, texture.Data.Height);
			Assert.Equal("test_pattern_transparent", texture.Data.InternalName);
			Assert.Equal(1.0f, texture.Data.AlphaTestValue);
			Assert.StartsWith(@"C:\", texture.Data.Path);
			Assert.Equal(image, blob);
		}

		[Fact]
		public void ShouldLoadCorrectTransparentXrgb()
		{
			var texture = _table.Textures["test_pattern_xrgb"];
			var blob = texture.FileContent;
			var image = File.ReadAllBytes(@"..\..\Fixtures\test_pattern_xrgb.bmp");
			//File.WriteAllBytes(@"..\..\Fixtures\debug.bmp", textureData);
			Assert.Equal(1024, texture.Data.Width);
			Assert.Equal(768, texture.Data.Height);
			Assert.Equal("test_pattern_xrgb", texture.Data.InternalName);
			Assert.Equal(1.0f, texture.Data.AlphaTestValue);
			Assert.StartsWith(@"C:\", texture.Data.Path);
			Assert.Equal(image, blob);
		}
	}
}
