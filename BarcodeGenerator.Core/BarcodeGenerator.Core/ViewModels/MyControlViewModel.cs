using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Runtime.InteropServices.ComTypes;
using BarcodeGenerator.Core.Models;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace BarcodeGenerator.Core.ViewModels
{
	public class MyControlViewModel : BindableBase, IDisposable
	{
		private CompositeDisposable Disposable { get; } = new CompositeDisposable();
		public VTuberRandom Model { get; }
		public ReactiveProperty<string> Name { get; set; }
		public ReactiveCommand RandomCommand { get; private set; } = new ReactiveCommand();

		public MyControlViewModel(VTuberRandom model)
		{
			Model = model;

			Name = Model.ObserveProperty(x => x.Name)
				.Where(x => x != null)
				.Select(x => x.Contains("九条") ? $"{x}様" : x)
				.ToReactiveProperty()
				.AddTo(Disposable);

			RandomCommand.Subscribe(_ => Model.RandomNameSet());
		}

		public void Dispose() => Disposable.Dispose();
	}
}
