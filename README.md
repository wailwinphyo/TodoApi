# Testing SOLID in c#

## Test results

- Expected result -> **Validation with XML**
``` bash
curl -X POST -d "{'hello': 'world'}" https://localhost:5001/Test/create -i -k -H "Content-Type: application/xml"
```
- Expected result -> **Validation with JSON**
``` bash
curl -X POST -d "{'hello': 'world'}" https://localhost:5001/Test/create -i -k -H "Content-Type: application/json"
```

- Expected result -> **Unsupported request data**
``` bash
curl -X POST -d "{'hello': 'world'}" https://localhost:5001/Test/create -i -k -H "Content-Type: application/octet-stream"
```
