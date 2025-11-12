# *What is ndjson?*

**NDJSON** (Newline Delimited JSON), also known as **JSON Lines (JSONL)** or Line delimited JSON (LDJSON), is a plain text data format where each line is a single, valid, self-contained JSON object. These objects are separated by newline characters `(\n` or `\r\n)`, and the file is not wrapped in a single large JSON array (square brackets).

## Key Characteristics

- **One JSON object per line:** Each line is an independent, complete JSON structure (object, array, or other value).
- **Newline separation:** The newline character is the sole delimiter between records; there are no commas between lines or after the last object.
- **Streaming-friendly:** Data can be processed line by line (incrementally) without the need to load the entire dataset into memory, making it ideal for very large datasets, log files, and data streaming protocols.
- **Error isolation:** A syntax error in one line does not necessarily prevent the parsing of valid objects on other lines.
- **UTF-8 encoding:** Files should be encoded in UTF-8.
- **File extension and MIME type:** The recommended file extension is `.ndjson` or `.jsonl`, and the suggested MIME type is `application/x-ndjson`.

## Use Cases and Benefits

**NDJSON is commonly used for:**

- **Streaming large datasets:** Enables efficient data transfer over protocols like TCP or UNIX pipes.
- **Log files:** Log entries can be appended to the file easily, and each entry is a searchable, structured JSON object.
- **Big data processing:** Well-suited for machine learning data preparation and ETL pipelines, where data is often processed in batches or incrementally.
- **API responses:** Some APIs use NDJSON to stream large result sets, allowing clients to start processing data as soon as the first line is received.

### Example

```json
{"name":"John", "age":30}
{"name":"Jane", "age":25}
{"name":"Bob", "age":42}
```

In this example, each line is a distinct, valid JSON object separated by a newline character. A standard JSON file with the same data would look like this, using array wrapping and commas:

```json
[
  {"name":"John", "age":30},
  {"name":"Jane", "age":25},
  {"name":"Bob", "age":42}
]
```
