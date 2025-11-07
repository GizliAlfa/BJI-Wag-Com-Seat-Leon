using Spectre.Console;
using VcdsHelper.Models;
using VcdsHelper.Services;

namespace VcdsHelper;

class Program
{
    private static VcdsDataService? _dataService;

    static void Main(string[] args)
    {
        _dataService = new VcdsDataService();

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        ShowWelcomeScreen();
        ShowMainMenu();
    }

    static void ShowWelcomeScreen()
    {
        AnsiConsole.Clear();
        
        var rule = new Rule("[bold yellow]BJI VCDS Helper[/]")
        {
            Style = Style.Parse("yellow"),
            Justification = Justify.Center
        };
        AnsiConsole.Write(rule);
        
        AnsiConsole.WriteLine();
        
        var panel = new Panel(
            Align.Center(
                new Markup("[bold cyan]2016 Seat Leon Style Paket[/]\n" +
                          "[dim]VCDS Parametreleri ve Kodlama Tarifleri[/]\n\n" +
                          "[yellow]Versiyon:[/] 1.0.4 [dim](Beta)[/]\n" +
                          "[yellow]Araç:[/] Seat Leon 5F1 (MQB Platform)\n" +
                          "[yellow]Yıl:[/] 2016\n" +
                          "[yellow]Paket:[/] Style"),
                VerticalAlignment.Middle))
        {
            Border = BoxBorder.Double,
            BorderStyle = Style.Parse("cyan")
        };
        
        AnsiConsole.Write(panel);
        AnsiConsole.WriteLine();
    }

    static void ShowMainMenu()
    {
        while (true)
        {
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[bold green]Ana Menü[/]")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Daha fazla seçenek görmek için yukarı/aşağı ok)[/]")
                    .AddChoices(new[]
                    {
                        "[cyan]>[/] Tüm Parametreleri Görüntüle",
                        "[cyan]>[/] Leuchte (Işık) Kanalları",
                        "[magenta]>[/] Leuchte Kodları Rehberi (BLK/DIM/SLH)",
                        "[cyan]>[/] Kodlama Tarifleri",
                        "[cyan]>[/] Parametre Ara",
                        "[cyan]>[/] Kategoriye Göre Gör",
                        "[cyan]>[/] Modüle Göre Gör",
                        "[yellow]?[/] Hakkında",
                        "[red]X[/] Çıkış"
                    }));

            switch (choice)
            {
                case "[cyan]>[/] Tüm Parametreleri Görüntüle":
                    ShowAllParameters();
                    break;
                case "[cyan]>[/] Leuchte (Işık) Kanalları":
                    ShowLeuchteChannels();
                    break;
                case "[magenta]>[/] Leuchte Kodları Rehberi (BLK/DIM/SLH)":
                    ShowLeuchteCodes();
                    break;
                case "[cyan]>[/] Kodlama Tarifleri":
                    ShowCodingRecipes();
                    break;
                case "[cyan]>[/] Parametre Ara":
                    SearchParameters();
                    break;
                case "[cyan]>[/] Kategoriye Göre Gör":
                    ShowByCategory();
                    break;
                case "[cyan]>[/] Modüle Göre Gör":
                    ShowByModule();
                    break;
                case "[yellow]?[/] Hakkında":
                    ShowAbout();
                    break;
                case "[red]X[/] Çıkış":
                    AnsiConsole.MarkupLine("[yellow]Program kapatılıyor...[/]");
                    return;
            }
        }
    }

    static void ShowAllParameters()
    {
        AnsiConsole.Clear();
        var parameters = _dataService!.GetParameters();

        if (parameters.Count == 0)
        {
            AnsiConsole.MarkupLine("[red]Henüz parametre yüklenmedi![/]");
            AnsiConsole.MarkupLine("[yellow]Data klasöründe parameters.json dosyası bulunamadı.[/]");
            AnsiConsole.WriteLine();
            AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
            return;
        }

        var table = new Table();
        table.Border(TableBorder.Rounded);
        table.AddColumn(new TableColumn("[bold yellow]Parametre[/]").Centered());
        table.AddColumn(new TableColumn("[bold cyan]Açıklama[/]"));
        table.AddColumn(new TableColumn("[bold green]Modül[/]").Centered());
        table.AddColumn(new TableColumn("[bold magenta]Default[/]").Centered());

        foreach (var param in parameters.Take(50)) // İlk 50 parametre
        {
            var paramName = param.IsCritical ? $"[red]{param.Name}[/]" : $"[white]{param.Name}[/]";
            var description = param.IsUnsure ? $"{param.Description} [yellow](!)[/]" : param.Description;
            
            table.AddRow(
                paramName,
                description,
                $"[cyan]{param.Module}[/]",
                $"[green]{param.DefaultValue}[/]"
            );
        }

        AnsiConsole.Write(table);
        
        if (parameters.Count > 50)
        {
            AnsiConsole.MarkupLine($"\n[yellow]Toplam {parameters.Count} parametre bulundu. İlk 50 tanesi gösteriliyor.[/]");
        }
        
        AnsiConsole.WriteLine();
        AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
    }

    static void ShowLeuchteChannels()
    {
        AnsiConsole.Clear();
        var channels = _dataService!.GetLeuchteChannels();

        if (channels.Count == 0)
        {
            AnsiConsole.MarkupLine("[red]Henüz Leuchte kanalı yüklenmedi![/]");
            AnsiConsole.MarkupLine("[yellow]Data klasöründe leuchte.json dosyası bulunamadı.[/]");
            AnsiConsole.WriteLine();
            AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
            return;
        }

        var table = new Table();
        table.Border(TableBorder.Rounded);
        table.AddColumn(new TableColumn("[bold yellow]Kanal[/]").Centered());
        table.AddColumn(new TableColumn("[bold cyan]İsim[/]"));
        table.AddColumn(new TableColumn("[bold green]Konum[/]"));
        table.AddColumn(new TableColumn("[bold magenta]Durum[/]").Centered());

        foreach (var channel in channels)
        {
            var status = channel.IsStandardInStyle ? "[green]✓ Standart[/]" : 
                        channel.IsOptional ? "[yellow]⚠ Opsiyonel[/]" : "[red]✗ Yok[/]";
            
            table.AddRow(
                $"[yellow]{channel.Channel}[/]",
                channel.Name,
                channel.Location,
                status
            );
        }

        AnsiConsole.Write(table);
        AnsiConsole.WriteLine();
        AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
    }

    static void ShowCodingRecipes()
    {
        var recipes = _dataService!.GetCodingRecipes();

        if (recipes.Count == 0)
        {
            AnsiConsole.Clear();
            AnsiConsole.MarkupLine("[red]Henüz kodlama tarifi yüklenmedi![/]");
            AnsiConsole.MarkupLine("[yellow]Data klasöründe recipes.json dosyası bulunamadı.[/]");
            AnsiConsole.WriteLine();
            AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
            return;
        }

        const int itemsPerPage = 20;
        int currentPage = 0;
        int totalPages = (int)Math.Ceiling(recipes.Count / (double)itemsPerPage);

        while (true)
        {
            AnsiConsole.Clear();
            
            // Mevcut sayfadaki tarifleri al
            var pagedRecipes = recipes
                .Skip(currentPage * itemsPerPage)
                .Take(itemsPerPage)
                .ToList();

            var choices = pagedRecipes.Select(r => $"{GetDifficultyIcon(r.Difficulty)} {r.Name}").ToList();
            
            // Navigasyon seçenekleri
            var navOptions = new List<string>();
            if (currentPage > 0)
                navOptions.Add("[blue]<< Önceki Sayfa[/]");
            if (currentPage < totalPages - 1)
                navOptions.Add("[blue]Sonraki Sayfa >>[/]");
            navOptions.Add("[red]<[/] Ana Menüye Dön");
            
            choices.AddRange(navOptions);

            var title = $"[bold green]Kodlama Tarifleri[/] [dim](Sayfa {currentPage + 1}/{totalPages} - Toplam {recipes.Count} tarif)[/]";
            
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title(title)
                    .PageSize(25)
                    .AddChoices(choices));

            if (choice == "[red]<[/] Ana Menüye Dön")
            {
                return;
            }
            else if (choice == "[blue]<< Önceki Sayfa[/]")
            {
                currentPage--;
            }
            else if (choice == "[blue]Sonraki Sayfa >>[/]")
            {
                currentPage++;
            }
            else
            {
                // Seçilen tarifi göster
                var selectedRecipe = recipes.FirstOrDefault(r => choice.Contains(r.Name));
                if (selectedRecipe != null)
                {
                    ShowRecipeDetails(selectedRecipe);
                }
            }
        }
    }

    static void ShowRecipeDetails(CodingRecipe recipe)
    {
        AnsiConsole.Clear();
        
        var panel = new Panel(
            new Markup($"[bold yellow]{recipe.Name}[/]\n\n" +
                      $"[cyan]{recipe.Description}[/]\n\n" +
                      $"[green]Modül:[/] {recipe.Module}\n" +
                      $"[green]Kategori:[/] {recipe.Category}\n" +
                      $"[green]Zorluk:[/] {GetDifficultyText(recipe.Difficulty)}\n" +
                      (recipe.RequiresHardware ? $"[red]⚠ Donanım Gerekli:[/] {recipe.HardwareRequired}\n" : "")))
        {
            Border = BoxBorder.Double,
            BorderStyle = Style.Parse("cyan")
        };
        
        AnsiConsole.Write(panel);
        AnsiConsole.WriteLine();

        // Adımları göster
        if (recipe.Steps.Count > 0)
        {
            AnsiConsole.MarkupLine("[bold yellow]Kodlama Adımları:[/]\n");
            
            var table = new Table();
            table.Border(TableBorder.Rounded);
            table.AddColumn("[bold]Parametre[/]");
            table.AddColumn("[bold]Eski Değer[/]");
            table.AddColumn("[bold]Yeni Değer[/]");
            table.AddColumn("[bold]Açıklama[/]");

            foreach (var step in recipe.Steps)
            {
                table.AddRow(
                    $"[cyan]{step.Parameter}[/]",
                    $"[red]{step.DefaultValue}[/]",
                    $"[green]{step.NewValue}[/]",
                    step.Explanation
                );
            }
            
            AnsiConsole.Write(table);
            AnsiConsole.WriteLine();
        }

        // Uyarıları göster
        if (recipe.Warnings.Count > 0)
        {
            var warningPanel = new Panel(string.Join("\n", recipe.Warnings.Select(w => $"[yellow](!)[/] {w}")))
            {
                Header = new PanelHeader("[bold red]UYARILAR[/]"),
                Border = BoxBorder.Heavy,
                BorderStyle = Style.Parse("red")
            };
            AnsiConsole.Write(warningPanel);
            AnsiConsole.WriteLine();
        }

        AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
    }

    static void SearchParameters()
    {
        var searchQuery = AnsiConsole.Prompt(
            new TextPrompt<string>("[yellow]Arama terimi girin:[/]")
                .PromptStyle("green"));

        var results = _dataService!.SearchParameters(searchQuery);

        AnsiConsole.Clear();
        
        if (results.Count == 0)
        {
            AnsiConsole.MarkupLine($"[red]'{searchQuery}' için sonuç bulunamadı.[/]");
        }
        else
        {
            AnsiConsole.MarkupLine($"[green]{results.Count} sonuç bulundu:[/]\n");
            
            var table = new Table();
            table.Border(TableBorder.Rounded);
            table.AddColumn("[bold]Parametre[/]");
            table.AddColumn("[bold]Açıklama[/]");
            table.AddColumn("[bold]Modül[/]");

            foreach (var param in results)
            {
                table.AddRow(
                    $"[yellow]{param.Name}[/]",
                    param.Description,
                    $"[cyan]{param.Module}[/]"
                );
            }
            
            AnsiConsole.Write(table);
        }

        AnsiConsole.WriteLine();
        AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
    }

    static void ShowByCategory()
    {
        var categories = _dataService!.GetCategories();

        if (categories.Count == 0)
        {
            AnsiConsole.MarkupLine("[red]Kategori bulunamadı![/]");
            AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
            return;
        }

        var choices = categories.Select(c => $"[cyan]>[/] {c.Name}").ToList();
        choices.Add("[red]<[/] Ana Menüye Dön");

        var choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[bold green]Kategori Seçin[/]")
                .AddChoices(choices));

        if (choice == "[red]<[/] Ana Menüye Dön") return;

        var category = categories.FirstOrDefault(c => choice.Contains(c.Name));
        if (category != null)
        {
            var parameters = _dataService.GetParametersByCategory(category.Id);
            DisplayParameters(parameters, category.Name);
        }
    }

    static void ShowByModule()
    {
        var modules = new[]
        {
            "09 - Central Electronics",
            "17 - Instrument Cluster",
            "19 - CAN Gateway",
            "46 - Central Comfort System",
            "5F - Information Electronics",
            "55 - Headlight Range Control",
            "08 - Air Conditioning",
            "[red]<[/] Ana Menüye Dön"
        };

        var choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[bold green]Modül Seçin[/]")
                .AddChoices(modules));

        if (choice == "[red]<[/] Ana Menüye Dön") return;

        var parameters = _dataService!.GetParametersByModule(choice);
        DisplayParameters(parameters, choice);
    }

    static void ShowLeuchteCodes()
    {
        while (true)
        {
            AnsiConsole.Clear();
            
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[bold magenta]Leuchte Kodları Rehberi[/]")
                    .PageSize(12)
                    .AddChoices(new[]
                    {
                        "[cyan]>[/] BLK Kodları (Yanıp Sönme)",
                        "[cyan]>[/] DIM Kodları (Parlaklık)",
                        "[cyan]>[/] SLH Kodları (Lamba Tipi)",
                        "[cyan]>[/] Almanca Terimler Sözlüğü",
                        "[cyan]>[/] Örnek Kodlamalar",
                        "[red]<[/] Ana Menüye Dön"
                    }));

            if (choice == "[red]<[/] Ana Menüye Dön") return;

            AnsiConsole.Clear();

            switch (choice)
            {
                case "[cyan]>[/] BLK Kodları (Yanıp Sönme)":
                    ShowBLKCodes();
                    break;
                case "[cyan]>[/] DIM Kodları (Parlaklık)":
                    ShowDIMCodes();
                    break;
                case "[cyan]>[/] SLH Kodları (Lamba Tipi)":
                    ShowSLHCodes();
                    break;
                case "[cyan]>[/] Almanca Terimler Sözlüğü":
                    ShowGermanTerms();
                    break;
                case "[cyan]>[/] Örnek Kodlamalar":
                    ShowLeuchteExamples();
                    break;
            }
        }
    }

    static void ShowBLKCodes()
    {
        var table = new Table();
        table.Border(TableBorder.Heavy);
        table.AddColumn("[bold]Kod[/]");
        table.AddColumn("[bold]İsim[/]");
        table.AddColumn("[bold]Davranış[/]");
        table.AddColumn("[bold]Kullanım[/]");

        table.AddRow("[yellow]BLK0[/]", "No Blink", "Sabit yanar", "Farlar, park lambaları");
        table.AddRow("[yellow]BLK1[/]", "Slow Blink", "Yavaş yanıp sönme (0.5 Hz)", "Uyarı lambaları");
        table.AddRow("[yellow]BLK2[/]", "Normal Blink", "Normal yanıp sönme (1 Hz)", "[green]Sinyal lambaları[/]");
        table.AddRow("[yellow]BLK3[/]", "Fast Blink", "Hızlı yanıp sönme (2 Hz)", "Arıza uyarısı");
        table.AddRow("[yellow]BLK4[/]", "Double Flash", "Çift flaş", "Özel efektler");
        table.AddRow("[yellow]BLK5[/]", "Triple Flash", "Üç kez yanıp sönme", "Şerit değiştirme");
        table.AddRow("[yellow]BLK6[/]", "Comfort Blink", "Konfor yanıp sönme", "3x yanıp söner");
        table.AddRow("[yellow]BLK7[/]", "Fade In/Out", "Yumuşak açılma/kapanma", "[green]Coming Home[/]");
        table.AddRow("[yellow]BLK8[/]", "Pulse", "Nabız gibi", "Alarm lambası");
        table.AddRow("[yellow]BLK10[/]", "Sequential", "Sıralı yanma", "[magenta]Dinamik sinyal[/]");

        AnsiConsole.Write(table);
        AnsiConsole.WriteLine();
        AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
    }

    static void ShowDIMCodes()
    {
        var table = new Table();
        table.Border(TableBorder.Heavy);
        table.AddColumn("[bold]Kod[/]");
        table.AddColumn("[bold]Parlaklık[/]");
        table.AddColumn("[bold]Yüzde[/]");
        table.AddColumn("[bold]Kullanım[/]");

        table.AddRow("[cyan]DIM0[/]", "Kapalı", "0%", "Lamba kapalı");
        table.AddRow("[cyan]DIM1[/]", "Çok Düşük", "10%", "Gece modu iç lambalar");
        table.AddRow("[cyan]DIM2[/]", "Düşük", "20%", "Ayak aydınlatma");
        table.AddRow("[cyan]DIM3[/]", "Orta-Düşük", "30%", "Park lambaları");
        table.AddRow("[cyan]DIM4[/]", "Orta", "40%", "[green]Coming Home[/]");
        table.AddRow("[cyan]DIM5[/]", "Orta", "50%", "İç lambalar");
        table.AddRow("[cyan]DIM6[/]", "Orta-Yüksek", "60%", "-");
        table.AddRow("[cyan]DIM7[/]", "Yüksek", "70%", "[green]DRL (Yasal)[/]");
        table.AddRow("[cyan]DIM8[/]", "Çok Yüksek", "80%", "-");
        table.AddRow("[cyan]DIM9[/]", "Maksimum", "90%", "-");
        table.AddRow("[cyan]DIM10[/]", "Tam Güç", "100%", "[green]Farlar, fren[/]");

        AnsiConsole.Write(table);
        AnsiConsole.WriteLine();
        AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
    }

    static void ShowSLHCodes()
    {
        var panel = new Panel(
            "[bold yellow]SLH Format:[/] [cyan][Modül]-[Çıkış]-[Tip][/]\n\n" +
            "[bold]Örnekler:[/]\n" +
            "• C1-58-05 = Sol kısa far (Halogen, dimming)\n" +
            "• C1-42-02 = Sol DRL (LED modül)\n" +
            "• C1-35-01 = Sol sis farı (Standart)\n" +
            "• C2-12-05 = İç tavan lambası (Dimming)\n" +
            "• C2-51-01 = Arka stop/fren lambası\n\n" +
            "[bold]Değerler:[/]\n" +
            "• [cyan]0[/] = Devre dışı / Lamba yok\n" +
            "• [cyan]1[/] = Aktif - Standart lamba\n" +
            "• [cyan]2[/] = LED modül\n" +
            "• [cyan]3[/] = Xenon modül\n" +
            "• [cyan]4[/] = Halogen\n" +
            "• [cyan]5[/] = Dimming destekli\n" +
            "• [cyan]6[/] = CAN kontrollü\n" +
            "• [cyan]7[/] = PWM kontrollü")
        {
            Header = new PanelHeader("[bold magenta]SLH Kodları (Lamba Tipi)[/]"),
            Border = BoxBorder.Heavy,
            BorderStyle = Style.Parse("magenta")
        };

        AnsiConsole.Write(panel);
        AnsiConsole.WriteLine();
        AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
    }

    static void ShowGermanTerms()
    {
        var table = new Table();
        table.Border(TableBorder.Rounded);
        table.AddColumn("[bold]Almanca[/]");
        table.AddColumn("[bold]Türkçe[/]");
        table.AddColumn("[bold]Açıklama[/]");

        table.AddRow("[yellow]Standlicht[/]", "Park lambası", "Pozisyon lambası");
        table.AddRow("[yellow]Begrenzunglicht[/]", "Park lambası", "Sınırlayıcı ışık");
        table.AddRow("[yellow]Positionslicht[/]", "Pozisyon lambası", "Yan lambalar");
        table.AddRow("[yellow]Abblendlicht[/]", "Kısa far", "-");
        table.AddRow("[yellow]Fernlicht[/]", "Uzun far", "-");
        table.AddRow("[yellow]Tagfahrlicht[/]", "Gündüz farı", "DRL");
        table.AddRow("[yellow]Nebelscheinwerfer[/]", "Sis farı", "Ön sis farı");
        table.AddRow("[yellow]Nebelschlussleuchte[/]", "Sis lambası", "Arka sis lambası");
        table.AddRow("[yellow]Blinker[/]", "Sinyal", "Sinyal lambası");
        table.AddRow("[yellow]Bremslicht[/]", "Fren lambası", "-");
        table.AddRow("[yellow]Rückfahrlicht[/]", "Geri vites", "Geri vites lambası");
        table.AddRow("[yellow]Blinkfunktion[/]", "Yanıp sönme", "BLK kodları");
        table.AddRow("[yellow]Dimmfunktion[/]", "Karartma", "DIM kodları");

        AnsiConsole.Write(table);
        AnsiConsole.WriteLine();
        AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
    }

    static void ShowLeuchteExamples()
    {
        var panel = new Panel(
            "[bold yellow]1. Coming Home Efekti:[/]\n" +
            "Leuchte0 (Sol Kısa Far)\n" +
            "├─ SLH = C1-58-05  (Halogen, dimming)\n" +
            "├─ BLK = [cyan]BLK7[/]      (Fade in/out - yumuşak)\n" +
            "└─ DIM = [cyan]DIM4[/]      (40% parlaklık)\n\n" +
            "[bold yellow]2. DRL Aktivasyonu:[/]\n" +
            "Leuchte4 (Sol DRL)\n" +
            "├─ SLH = C1-42-02  (LED modül)\n" +
            "├─ BLK = [cyan]BLK0[/]      (Sabit yanma)\n" +
            "└─ DIM = [cyan]DIM7[/]      (70% - yasal standart)\n\n" +
            "[bold yellow]3. Dinamik Sinyal (LED gerekli!):[/]\n" +
            "Leuchte6 (Sol Ön Sinyal)\n" +
            "├─ SLH = C1-28-02  (LED modül)\n" +
            "├─ BLK = [cyan]BLK10[/]     (Sequential - sıralı)\n" +
            "└─ DIM = [cyan]DIM10[/]     (Tam güç)")
        {
            Header = new PanelHeader("[bold green]Örnek Kodlamalar[/]"),
            Border = BoxBorder.Double,
            BorderStyle = Style.Parse("green")
        };

        AnsiConsole.Write(panel);
        AnsiConsole.WriteLine();
        AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
    }

    static void DisplayParameters(List<VcdsParameter> parameters, string title)
    {
        AnsiConsole.Clear();
        
        if (parameters.Count == 0)
        {
            AnsiConsole.MarkupLine($"[yellow]{title}[/] için parametre bulunamadı.");
        }
        else
        {
            AnsiConsole.MarkupLine($"[bold green]{title}[/] - {parameters.Count} parametre\n");
            
            var table = new Table();
            table.Border(TableBorder.Rounded);
            table.AddColumn("[bold]Parametre[/]");
            table.AddColumn("[bold]Açıklama[/]");
            table.AddColumn("[bold]Default[/]");
            table.AddColumn("[bold]Önerilen[/]");

            foreach (var param in parameters)
            {
                table.AddRow(
                    $"[yellow]{param.Name}[/]",
                    param.Description,
                    $"[red]{param.DefaultValue}[/]",
                    $"[green]{param.RecommendedValue}[/]"
                );
            }
            
            AnsiConsole.Write(table);
        }

        AnsiConsole.WriteLine();
        AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
    }

    static void ShowAbout()
    {
        AnsiConsole.Clear();
        
        var panel = new Panel(
            new Markup(
                "[bold yellow]BJI VCDS Helper[/]\n\n" +
                "[cyan]Versiyon:[/] 1.0.2 [dim](Beta)[/]\n" +
                "[cyan]Geliştirici:[/] GizliAlfa\n" +
                "[cyan]Tarih:[/] 8 Kasım 2025\n\n" +
                "[bold green]Hedef Araç:[/]\n" +
                "• Model: 2016 Seat Leon (5F1)\n" +
                "• Platform: MQB\n" +
                "• Paket: Style\n\n" +
                "[bold yellow]Özellikler:[/]\n" +
                "• VCDS parametreleri görüntüleme\n" +
                "• Leuchte (ışık) kanalları\n" +
                "• Kodlama tarifleri\n" +
                "• Parametre arama\n" +
                "• Kategori ve modül bazlı filtreleme\n\n" +
                "[dim]GitHub: GizliAlfa/BJI-Wag-Com-Seat-Leon[/]"))
        {
            Border = BoxBorder.Double,
            BorderStyle = Style.Parse("cyan"),
            Header = new PanelHeader("[bold]Hakkında[/]")
        };
        
        AnsiConsole.Write(panel);
        AnsiConsole.WriteLine();
        AnsiConsole.Prompt(new TextPrompt<string>("[grey]Devam etmek için Enter'a basın...[/]").AllowEmpty());
    }

    static string GetDifficultyIcon(DifficultyLevel difficulty)
    {
        return difficulty switch
        {
            DifficultyLevel.Easy => "[green]*[/]",
            DifficultyLevel.Medium => "[yellow]*[/]",
            DifficultyLevel.Hard => "[orange1]*[/]",
            DifficultyLevel.Expert => "[red]*[/]",
            _ => "[grey]*[/]"
        };
    }

    static string GetDifficultyText(DifficultyLevel difficulty)
    {
        return difficulty switch
        {
            DifficultyLevel.Easy => "[green]Kolay (Güvenle yapılabilir)[/]",
            DifficultyLevel.Medium => "[yellow]Orta (Dikkatli olunmalı)[/]",
            DifficultyLevel.Hard => "[orange1]Zor (Deneyim gerekli)[/]",
            DifficultyLevel.Expert => "[red]Uzman (Donanım gerekli)[/]",
            _ => "[grey]Bilinmiyor[/]"
        };
    }
}
