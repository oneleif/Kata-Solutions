// Kata: https://www.codewars.com/kata/59901fb5917839fe41000029
func numericFormatter(_ template: String, _ numbers: String = "1234567890") -> String {
    var i = 0
    return template.characters.map { c in
        if let value = Int("\(c)") {
            return "\(value)"
        } else {
            if c == " " || c == "*" || c == "+" || c == "/" || c == "-"   {
                return "\(c)"
            }
            let value = numbers.characters.map { $0 }[i % numbers.characters.count]
            i += 1
            return "\(value)"
        }
    }.reduce("", +)
}